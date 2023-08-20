using Application.InterfaceQuery;
using Domain.Model;
using Microsoft.AspNetCore.Mvc;
using System.Net;
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

        [HttpPost(Name = "AddUser")]
        public HttpStatusCode AddUser(User user)
        {

            try
            {
                bool result = _userApplication.CreateUser(user);
                return HttpStatusCode.Created;
            }
            catch (Exception ex)
            {
                return HttpStatusCode.Forbidden;
            }
        }
    }
}
