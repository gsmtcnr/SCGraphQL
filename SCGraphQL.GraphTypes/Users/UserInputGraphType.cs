using GraphQL.Types;
using SCGraphQL.Model;

namespace SCGraphQL.GraphTypes
{
    public class UserInputGraphType : InputObjectGraphType<UserDto>, ISingletonGraphType
    {
        public UserInputGraphType()
        {
            Field(s => s.Name);
            Field(s => s.Surname, nullable: true);
        }
    }
}
