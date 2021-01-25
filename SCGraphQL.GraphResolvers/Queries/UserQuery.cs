using GraphQL;
using GraphQL.Types;
using SCGraphQL.GraphTypes;
using SCGraphQL.IoCManagement;
using SCGraphQL.Service;
using System;

namespace SCGraphQL.GraphResolvers.Queries
{
    public class UserQuery : ObjectGraphType, IQueryResolver
    {
        public UserQuery()
        {
            Name = "UserQuery";
            IUserService userService = IoCManager.Resolve<IUserService>();
            Field<UserGraphType>
               (
                   name: "getUser",
                   arguments: new QueryArguments(new QueryArgument<GuidGraphType>
                   {
                       Name = "id"
                   }),
                resolve: context => userService.GetById(context.GetArgument<Guid>("id"))
               );

            Field<ListGraphType<UserGraphType>>
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
