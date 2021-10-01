using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Request;
using Models.Respose;
using Services.User;

namespace Shop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        // GET: api/User
        // [HttpGet]
        // public IActionResult Get()
        // {
        //    
        // }

        [HttpPost("signin")]
        public IActionResult SignIn([FromBody] SignInDto body)
        {
            Status respose = new Status();
            var result = _userService.SignIn(body);
            if (result == null)
            {
                respose.Message = "User or password incorrect";
                return BadRequest(respose);
            }
            respose.Exito = 1;
            respose.Data = result;
            return Ok(respose);
        }

        // PUT: api/User/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/User/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
