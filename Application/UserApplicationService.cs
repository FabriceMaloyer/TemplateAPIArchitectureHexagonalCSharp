
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

        public bool CreateUser(User user)
        {
            return _userRepository.CreateUser(user);
        }

        public List<User> GetAllUser()
        {
            return _userRepository.GetAllUser();
        }

        public User GetUserById(Guid id)
        {
            return _userRepository.GetUserById(id);
        }
    }
}
