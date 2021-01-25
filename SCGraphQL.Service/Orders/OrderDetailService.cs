using SCGraphQL.Model;

namespace SCGraphQL.Service
{
    public class OrderDetailService : BaseService<OrderDetailDto>, IOrderDetailService
    {
    }
    public interface IOrderDetailService : IService<OrderDetailDto>
    {

    }
}
