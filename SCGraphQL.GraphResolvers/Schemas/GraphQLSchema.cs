using GraphQL.Types;
using System;

namespace SCGraphQL.Presentation.Schemas
{
    public class GraphQLSchema : Schema
    {
        public GraphQLSchema(IServiceProvider provider)
          : base(provider)
        {
       
            Query = (GraphQLQuery)provider.GetService(typeof(GraphQLQuery));
            Mutation = (GraphQLMutation)provider.GetService(typeof(GraphQLMutation));
        }
    }
}
