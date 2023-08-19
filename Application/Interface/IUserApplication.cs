using Domain.Model;

namespace Application.Interface
{
    public interface IUserApplication
    {
        List<User> GetAllUser();
        User GetUserById(Guid id);
    }
}
