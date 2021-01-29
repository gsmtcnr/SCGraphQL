using SCGraphQL.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SCGraphQL.Service
{
    public class OrderDetailService : BaseService<OrderDetailDto>, IOrderDetailService
    {
        public List<OrderDetailDto> GetListByOrderId(Guid orderId)
        {
            return DummyList.Where(s => s.OrderId == orderId).ToList();
        }
    }
    public interface IOrderDetailService : IService<OrderDetailDto>
    {
        public List<OrderDetailDto> GetListByOrderId(Guid orderId);
    }
}
