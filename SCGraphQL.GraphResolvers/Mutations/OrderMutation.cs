using GraphQL.Types;
using SCGraphQL.Service;

namespace SCGraphQL.GraphResolvers.Mutations
{
    public class OrderMutation : ObjectGraphType, IMutationResolver
    {
      
        public OrderMutation()
        {
            Name = "OrderMutation";
            OrderService orderService = new OrderService();
            //Field<OrderGraphType>
            //  (
            //      name: "insertOrder",
            //      arguments: new QueryArguments(new QueryArgument<NonNullGraphType<OrderInputGraphType>> { Name = "inputModel" }),
            //      resolve: context =>
            //      {
            //          OrderDto inputModel = context.GetArgument<OrderDto>("inputModel");
            //          return orderService.Insert(inputModel);
            //      }
            //  );
        }
    }
}
