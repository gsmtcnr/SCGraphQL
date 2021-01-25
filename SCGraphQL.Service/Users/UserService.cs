using SCGraphQL.Model;

namespace SCGraphQL.Service
{
    public class UserService : BaseService<UserDto>, IUserService
    {
    }
    public interface IUserService : IService<UserDto>
    {

    }
}
