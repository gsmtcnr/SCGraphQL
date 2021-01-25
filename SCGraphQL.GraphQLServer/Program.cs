using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading.Tasks;

namespace SCGraphQL.GraphQLServer
{
    public class Program
    {
        public static Task Main(string[] args) => Host
           .CreateDefaultBuilder(args)
           .ConfigureWebHostDefaults(builder => builder.UseStartup<Startup>())
           .Build()
           .RunAsync();
    }
}
