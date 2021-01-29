using GraphQL;
using GraphQL.Types;
using SCGraphQL.GraphTypes;
using SCGraphQL.IoCManagement;
using SCGraphQL.Model;
using SCGraphQL.Service;

namespace SCGraphQL.GraphResolvers.Mutations
{
    public class OrderMutation : ObjectGraphType, IMutationResolver
    {
        public OrderMutation()
        {
            Name = nameof(OrderMutation);
            IOrderService orderService = IoCManager.Resolve<IOrderService>();
            Field<OrderGraphType>
              (
                  name: "insertOrder",
                  arguments: new QueryArguments(new QueryArgument<NonNullGraphType<OrderInputGraphType>>
                  {
                      Name = "inputModel"
                  }),
                  resolve: context =>
                  {
                      OrderDto inputModel = context.GetArgument<OrderDto>("inputModel");
                      return orderService.Insert(inputModel);
                  }
              );
        }
    }
}
