using GraphQL.Types;
using SCGraphQL.Model;

namespace SCGraphQL.GraphTypes
{
    public class OrderDetailInputGraphType : InputObjectGraphType<OrderDetailDto>
    {
        public OrderDetailInputGraphType()
        {
            Field(s => s.OrderId);
            Field(s => s.ProductName);
            Field(s => s.ProductPrice);
        }
    }
}
