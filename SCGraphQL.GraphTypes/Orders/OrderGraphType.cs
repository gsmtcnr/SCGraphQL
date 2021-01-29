using GraphQL.Types;
using SCGraphQL.IoCManagement;
using SCGraphQL.Model;
using SCGraphQL.Service;

namespace SCGraphQL.GraphTypes
{
    public class OrderGraphType : ObjectGraphType<OrderDto>, IScoppedGraphType
    {
        public OrderGraphType()
        {
            IOrderDetailService orderDetailService = IoCManager.Resolve<IOrderDetailService>();
            IUserService userService = IoCManager.Resolve<IUserService>();
            Field(s => s.Id);
            Field(s => s.UserId);
            Field<UserGraphType>
                 (
                     name: "user",
                     resolve: context =>
                     {
                         return userService.GetById(context.Source.UserId);
                     }
                 );
            Field(s => s.DiscountPrice, nullable: true);
            Field(s => s.TotalPrice);
            Field<ListGraphType<OrderDetailGraphType>>
            (
                name: "details",
                resolve: context =>
                {
                    return orderDetailService.GetListByOrderId(context.Source.Id);
                }
            );
        }
    }
}
