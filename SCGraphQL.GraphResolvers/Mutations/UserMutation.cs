using GraphQL;
using GraphQL.Types;
using SCGraphQL.GraphTypes;
using SCGraphQL.IoCManagement;
using SCGraphQL.Model;
using SCGraphQL.Service;

namespace SCGraphQL.GraphResolvers.Mutations
{
    public class UserMutation : ObjectGraphType, IMutationResolver
    {
        public UserMutation()
        {
            Name = "UserMutation";
            IUserService userService = IoCManager.Resolve<IUserService>();
            Field<UserGraphType>
              (
                  name: "insertUser",
                  arguments: new QueryArguments(new QueryArgument<NonNullGraphType<UserInputGraphType>>
                  {
                      Name = "inputModel"
                  }),
                  resolve: context =>
                  {
                      UserDto inputModel = context.GetArgument<UserDto>("inputModel");
                      return userService.Insert(inputModel);
                  }
              );
        }
    }
}
