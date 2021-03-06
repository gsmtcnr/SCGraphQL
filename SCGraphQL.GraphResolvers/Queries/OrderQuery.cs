﻿using GraphQL;
using GraphQL.Types;
using SCGraphQL.GraphTypes;
using SCGraphQL.IoCManagement;
using SCGraphQL.Service;
using System;

namespace SCGraphQL.GraphResolvers.Queries
{
    public class OrderQuery : ObjectGraphType, IQueryResolver
    {
        public OrderQuery()
        {
            Name = nameof(OrderQuery);
            IOrderService orderService = IoCManager.Resolve<IOrderService>();
            Field<OrderGraphType>
               (
                   name: "getOrder",
                   arguments: new QueryArguments(new QueryArgument<GuidGraphType>
                   {
                       Name = "id"
                   }),
                resolve: context => orderService.GetById(context.GetArgument<Guid>("id"))
               );

            Field<ListGraphType<OrderGraphType>>
              (
                  name: "getOrders",
                  resolve: context =>
                  {
                      return orderService.GetList();
                  }
              );
        }
    }
}
