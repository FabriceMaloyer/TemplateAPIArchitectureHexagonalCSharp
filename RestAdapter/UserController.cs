using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace RestAdapter
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IRequestUser _requestUser;

        public UserController(IRequestUser requestUser)
        {
            _requestUser = requestUser;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var result = _requestDeal.GetDeals();
            return Ok(result);
        }
    }
}
