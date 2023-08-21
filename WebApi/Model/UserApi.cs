using Domain.Model;

namespace WebApi.Model
{
    public class UserApi
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public static UserApi ConvertToApiModel(User user)
        {
            UserApi userApi = new UserApi();
            userApi.Id = (Guid)user.Id;
            userApi.Name = user.Name;
            userApi.Email = user.Email;
            userApi.Password = user.Password;
            return userApi;
        }

        public static User ConvertToModel(UserApi userApi)
        {
            User user = new User();

            return user;
        }
    }
}
