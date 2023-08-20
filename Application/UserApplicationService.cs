
using Application.InterfaceQuery;
using Domain.Model;

namespace Application
{
    public class UserApplicationService : IUserApplication
    {
        private readonly IUserRepository _userRepository;

        public UserApplicationService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public List<User> GetAllUser()
        {
            return _userRepository.GetAllUser();
        }

        public User GetUserById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
