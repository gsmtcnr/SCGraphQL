using System;

namespace SCGraphQL.Model
{
    public class UserAddressDto : BaseDto
    {
        public Guid UserId { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Town { get; set; }
        public string Address { get; set; }
    }
}
