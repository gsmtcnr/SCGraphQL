using GraphQL;
using GraphQL.Types;
using SCGraphQL.GraphTypes;
using SCGraphQL.IoCManagement;
using SCGraphQL.Model;
using SCGraphQL.Service;

namespace SCGraphQL.GraphResolvers.Mutations
{
    public class OrderDetailMutation : ObjectGraphType, IMutationResolver
    {
        public OrderDetailMutation()
        {
            Name = nameof(OrderDetailMutation);
            IOrderDetailService orderDetailService = IoCManager.Resolve<IOrderDetailService>();
            Field<OrderDetailGraphType>
              (
                  name: "insertOrderDetail",
                  arguments: new QueryArguments(new QueryArgument<NonNullGraphType<OrderDetailInputGraphType>>
                  {
                      Name = "inputModel"
                  }),
                  resolve: context =>
                  {
                      OrderDetailDto inputModel = context.GetArgument<OrderDetailDto>("inputModel");
                      return orderDetailService.Insert(inputModel);
                  }
              );
        }
    }
}
