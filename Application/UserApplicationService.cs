using Application.Interface;
using Domain.Model;

namespace Application
{
    public class UserApplicationService : IUserApplication
    {
        public List<User> GetAllUser()
        {
            throw new NotImplementedException();
        }

        public User GetUserById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
