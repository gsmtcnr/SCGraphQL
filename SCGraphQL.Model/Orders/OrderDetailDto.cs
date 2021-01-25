using System;

namespace SCGraphQL.Model
{
    public class OrderDetailDto : BaseDto
    {
        public Guid OrderId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
    }
}
