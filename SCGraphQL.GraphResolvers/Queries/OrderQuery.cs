using GraphQL.Types;
using SCGraphQL.Service;

namespace SCGraphQL.GraphResolvers.Queries
{
    public class OrderQuery : ObjectGraphType, IQueryResolver
    {
        public OrderQuery()
        {
            Name = "OrderQuery";
            OrderService orderService = new OrderService();
            //Field<OrderGraphType>
            //   (
            //       name: "getOrder",
            //       arguments: new QueryArguments(new QueryArgument<GuidGraphType> { Name = "id" }),
            //       resolve: context =>
            //       {
            //           Guid id = context.GetArgument<Guid>("id");
            //           return orderService.GetById(id);
            //       }
            //   );

            //Field<ListGraphType<OrderGraphType>>
            //  (
            //      name: "getOrders",
            //      resolve: context =>
            //      {
            //          return orderService.GetList();
            //      }
            //  );
        }
    }
}
