using GraphQL;
using GraphQL.Types;
using SCGraphQL.GraphTypes;
using SCGraphQL.IoCManagement;
using SCGraphQL.Service;
using System;

namespace SCGraphQL.GraphResolvers.Queries
{
    public class OrderDetailQuery : ObjectGraphType, IQueryResolver
    {
        public OrderDetailQuery()
        {
            Name = nameof(OrderDetailQuery);
            IOrderDetailService orderDetailService = IoCManager.Resolve<IOrderDetailService>();
            Field<ListGraphType<OrderGraphType>>
            (
                name: "getOrderDetails",
                resolve: context =>
                {
                    return orderDetailService.GetListByOrderId(context.GetArgument<Guid>("orderId"));
                }
            );
        }
    }
}
