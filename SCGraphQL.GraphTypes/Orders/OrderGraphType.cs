using GraphQL.Types;
using SCGraphQL.IoCManagement;
using SCGraphQL.Model;
using SCGraphQL.Service;

namespace SCGraphQL.GraphTypes
{
    public class OrderGraphType : ObjectGraphType<OrderDto>, ISingletonGraphType
    {
        public OrderGraphType()
        {
         
            Field(s => s.Id);
            Field(s => s.UserId);
            Field(s => s.DiscountPrice, nullable: true);
            Field(s => s.TotalPrice);


            IOrderDetailService orderDetailService = IoCManager.Resolve<IOrderDetailService>();
            IUserService userService = IoCManager.Resolve<IUserService>();
            Field<UserGraphType>
                 (
                     name: "user",
                     resolve: context =>
                     {
                         return userService.GetById(context.Source.UserId);
                     }
                 );
        
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
