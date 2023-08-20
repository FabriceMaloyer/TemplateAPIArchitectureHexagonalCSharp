using Application.InterfaceQuery;
using Domain.Model;
using Microsoft.AspNetCore.Mvc;
using WebApi.Model;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController
    {
        private readonly IUserApplication _userApplication;

        public UserController(IUserApplication userApplication)
        {
            this._userApplication = userApplication;
        }


        [HttpGet(Name = "GetAllUser")]
        public List<UserApi> GetAllUser()
        {
            List<User> users = _userApplication.GetAllUser();
            List<UserApi> result = new List<UserApi>();
            foreach (var item in users)
            {
                result.Add(UserApi.ConvertToApiModel(item));
            }

            return result;
        }

        [HttpGet("{id}", Name = "GetUserById")]
        public UserApi GetUserById(Guid id)
        {
            User user = _userApplication.GetUserById(id);

            return UserApi.ConvertToApiModel(user);
        }
    }
}
