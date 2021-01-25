using GraphQL.Types;
using SCGraphQL.Model;

namespace SCGraphQL.GraphTypes
{
    public class UserAddressGraphType : ObjectGraphType<UserAddressDto>, IScoppedGraphType
    {
        public UserAddressGraphType()
        {
            Field(s => s.Id);
            Field(s => s.UserId);
            Field(s => s.Country);
            Field(s => s.City);
            Field(s => s.Town);
            Field(s => s.Address);
        }
    }
}
