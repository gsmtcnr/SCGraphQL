using GraphQL.Types;
using SCGraphQL.Model;

namespace SCGraphQL.GraphTypes
{
    public class UserAddressInputGraphType : InputObjectGraphType<UserAddressDto>, IScoppedGraphType
    {
        public UserAddressInputGraphType()
        {
            Field(s => s.UserId);
            Field(s => s.Country);
            Field(s => s.City);
            Field(s => s.Town);
            Field(s => s.Address);
        }
    }
}
