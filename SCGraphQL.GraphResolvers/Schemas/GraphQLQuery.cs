using GraphQL.Types;
using SCGraphQL.GraphResolvers;
using SCGraphQL.IoCManagement;

namespace SCGraphQL.Presentation.Schemas
{
    public class GraphQLQuery : ObjectGraphType
    {
        public GraphQLQuery()
        {
            IQueryResolver[] list = IoCManager.ResolveAll<IQueryResolver>();
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
