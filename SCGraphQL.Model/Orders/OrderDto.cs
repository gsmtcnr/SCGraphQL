using System;

namespace SCGraphQL.Model
{
    public class OrderDto : BaseDto
    {
        public Guid UserId { get; set; }
        public decimal DiscountPrice { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
