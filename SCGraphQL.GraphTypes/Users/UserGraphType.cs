using GraphQL.Types;
using SCGraphQL.IoCManagement;
using SCGraphQL.Model;
using SCGraphQL.Service;

namespace SCGraphQL.GraphTypes
{
    public class UserGraphType : ObjectGraphType<UserDto>, ISingletonGraphType
    {
        public UserGraphType()
        {
            IOrderService orderService = IoCManager.Resolve<IOrderService>();
            Field(s => s.Id);
            Field(s => s.Name);
            Field(s => s.Surname, nullable: true);
            Field<ListGraphType<OrderGraphType>>
               (
                   name: "orders",
                   resolve: context =>
                   { 
                       return orderService.GetListByUserId(context.Source.Id);
                   }
               ); 
        }
    }
}
