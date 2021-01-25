using GraphQL.Server;
using GraphQL.Types;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SCGraphQL.IoCManagement;
using SCGraphQL.Presentation.Schemas;

namespace SCGraphQL.GraphQLServer
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            IoCManager.Install();
            services.AddSingleton<GraphQLMutation>();
            services.AddSingleton<GraphQLQuery>();
            services.AddSingleton<ISchema, GraphQLSchema>();
            services.AddLogging(builder => builder.AddConsole());
            services.AddHttpContextAccessor();
            services.AddGraphQL(options =>
            {
                options.EnableMetrics = true;
            })
            .AddErrorInfoProvider(opt => opt.ExposeExceptionStackTrace = true)
            .AddSystemTextJson();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
        
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            // add http for Schema at default url /graphql
            app.UseGraphQL<ISchema>();

            // use graphql-playground at default url /ui/playground
            app.UseGraphQLPlayground();
        }
    }
}
