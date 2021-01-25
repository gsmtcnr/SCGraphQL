using GraphQL;
using GraphQL.Types;
using SCGraphQL.GraphTypes;
using SCGraphQL.Service;
using System;

namespace SCGraphQL.GraphResolvers.Queries
{
    public class UserQuery : ObjectGraphType, IQueryResolver
    {
        public UserQuery()
        {
            Name = "UserQuery";
            UserService userService = new UserService();
            Field<OrderGraphType>
               (
                   name: "getUser",
                   arguments: new QueryArguments(new QueryArgument<GuidGraphType>
                   {
                       Name = "id"
                   }),
                resolve: context => userService.GetById(context.GetArgument<Guid>("id"))
               );

            Field<ListGraphType<OrderGraphType>>
              (
                  name: "getUsers",
                  resolve: context =>
                  {
                      return userService.GetList();
                  }
              );
        }
    }
}
