using SCGraphQL.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SCGraphQL.Service
{
    public class OrderService : BaseService<OrderDto>, IOrderService
    {
        public List<OrderDto> GetListByUserId(Guid userId)
        {
            return DummyList.Where(s => s.UserId == userId).ToList();
        }
    }
    public interface IOrderService : IService<OrderDto>
    {
        public List<OrderDto> GetListByUserId(Guid userId);
    }
}
