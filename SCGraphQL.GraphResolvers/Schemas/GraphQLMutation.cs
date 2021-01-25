using GraphQL.Types;
using SCGraphQL.GraphResolvers;
using SCGraphQL.IoCManagement;

namespace SCGraphQL.Presentation.Schemas
{
    public class GraphQLMutation : ObjectGraphType
    {
        public GraphQLMutation()
        {
            IMutationResolver[] list = IoCManager.ResolveAll<IMutationResolver>();
            foreach (var item in list)
            {
                ObjectGraphType<object> objectGraphType = item as ObjectGraphType<object>;
                foreach (var field in objectGraphType.Fields)
                {
                   
                    AddField(field);
                }
            }
        }
    }
}
