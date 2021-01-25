using GraphQL.Types;
using SCGraphQL.Model;

namespace SCGraphQL.GraphTypes
{
    public class UserGraphType : ObjectGraphType<UserDto>, IScoppedGraphType
    {
        public UserGraphType()
        {
            Field(s => s.Id);
            Field(s => s.Name);
            Field(s => s.Surname, nullable: true);
        }
    }
}
