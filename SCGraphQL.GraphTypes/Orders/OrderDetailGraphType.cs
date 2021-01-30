using GraphQL.Types;
using SCGraphQL.Model;

namespace SCGraphQL.GraphTypes
{
    public class OrderDetailGraphType : ObjectGraphType<OrderDetailDto>, ISingletonGraphType
    {
        public OrderDetailGraphType()
        {
            Field(s => s.Id);
            Field(s => s.OrderId);
            Field(s => s.ProductName);
            Field(s => s.ProductPrice);
        }
    }
}
