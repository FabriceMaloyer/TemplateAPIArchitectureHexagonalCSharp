using Domain.Model;

namespace Application.InterfaceQuery
{
    public interface IUserRepository
    {
        List<User> GetAllUser();
        User GetUserById(Guid id);
        bool CreateUser(User user);
        bool UpdateUser(User user);
        bool DeleteUser(Guid id);
        bool GetConnexion(User user);
    }
}
