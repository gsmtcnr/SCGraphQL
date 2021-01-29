using GraphQL.Types;
using Microsoft.Extensions.DependencyInjection;
using SCGraphQL.GraphTypes;
using SCGraphQL.IoCManagement;
using SCGraphQL.Presentation.Schemas;

namespace SCGraphQL.GraphQLServer
{
    public static class GraphStartupExtension
    {
        public static void AddGraphTypes(this IServiceCollection services)
        {
            services.AddSingleton<UserGraphType>();
            IScoppedGraphType[] list = IoCManager.ResolveAll<IScoppedGraphType>();
            foreach (IScoppedGraphType item in list)
            {
                services.AddSingleton(item.GetType());
            }
        }
        public static void AddGraphSchema(this IServiceCollection services)
        {
            services.AddSingleton<ISchema, GraphQLSchema>();
            services.AddSingleton<GraphQLMutation>();
            services.AddSingleton<GraphQLQuery>();
        }
    }
}
