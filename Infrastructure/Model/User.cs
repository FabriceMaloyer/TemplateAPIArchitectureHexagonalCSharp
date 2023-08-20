
using UserModel = Domain.Model.User;
namespace Infrastructure.Model
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public static User ToRepos(UserModel user)
        {
            User response = new User();

            response.Id = user.Id;
            response.Name = user.Name;
            response.Email = user.Email;
            response.Password = user.Password;

            return response;
        }

        public static UserModel ToModel(User user)
        {
            Domain.Model.User response = new Domain.Model.User();

            response.Id = user.Id;
            response.Name = user.Name;
            response.Email = user.Email;
            response.Password = user.Password;

            return response;
        }
    }
}
