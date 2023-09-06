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


        [HttpGet]
        [Route("GetAllUser")]
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

        [HttpGet]
        [Route("GetUserById")]
        public UserApi GetUserById(Guid id)
        {
            User user = _userApplication.GetUserById(id);

            return UserApi.ConvertToApiModel(user);
        }

        [HttpPost]
        [Route("connect")]
        public bool GetConnection(User user)
        {
            bool response = _userApplication.GetConnection(user);

            return response;
        }

        [HttpPost]
        [Route("AddUser")]
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

        [HttpPost]
        [Route("DeleteUser")]
        public HttpStatusCode DeleteUser(Guid id)
        {
            try
            {
                bool result = _userApplication.DeleteUser(id);
                return HttpStatusCode.OK;
            }
            catch (Exception ex)
            {
                return HttpStatusCode.Forbidden;
            }
        }

        [HttpPost]
        [Route("UpdateUser")]
        public HttpStatusCode UpdateUser(User user)
        {
            try
            {
                bool result = _userApplication.UpdateUser(user);
                return HttpStatusCode.OK;
            }
            catch (Exception ex)
            {
                return HttpStatusCode.Forbidden;
            }
        }

    }
}
