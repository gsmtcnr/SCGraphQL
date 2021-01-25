using GraphQL.Types;
using SCGraphQL.Model;

namespace SCGraphQL.GraphTypes
{
    public class OrderGraphType : ObjectGraphType<OrderDto>, IScoppedGraphType
    {
        public OrderGraphType()
        {
            Field(s => s.Id);
            Field(s => s.UserId);
            Field(s => s.UserAddressId);
            Field(s => s.TotalPrice);
        }
    }
}
