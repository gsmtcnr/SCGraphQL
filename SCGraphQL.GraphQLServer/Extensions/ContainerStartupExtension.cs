using Microsoft.Extensions.DependencyInjection;
using SCGraphQL.IoCManagement;

namespace SCGraphQL.GraphQLServer
{
    public static class ContainerStartupExtension
    {
        public static void InstallContainer(this IServiceCollection services)
        {
            //services'a ihtiyacımız şuan için yok ama ileride olabilir..
            IoCManager.Install();
        }
    }
}
