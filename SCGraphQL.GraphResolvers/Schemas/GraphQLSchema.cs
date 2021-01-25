using GraphQL.Types;
using GraphQL.Utilities;
using SCGraphQL.GraphTypes;
using SCGraphQL.IoCManagement;
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

            IScoppedGraphType[] list = IoCManager.ResolveAll<IScoppedGraphType>();
            foreach (var item in list)
            {
                RegisterType((IGraphType)item);
            }
        }
    }
}
