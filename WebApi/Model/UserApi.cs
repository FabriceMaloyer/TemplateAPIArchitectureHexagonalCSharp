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

            return userApi;
        }

        public static User ConvertToModel(UserApi userApi)
        {
            User user = new User();

            return user;
        }
    }
}
