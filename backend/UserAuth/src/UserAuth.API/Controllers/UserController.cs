using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using UserAuth.Core.Services;
using UserAuth.Core.Models.User;

namespace UserAuth.API.Controllers
{

    [Route("[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserService UserService;

        public UsersController(UserService userService) {
            this.UserService = userService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserDTO>>> GetAllUsers()
        {
            var users = await this.UserService.GetAllUsers();
            return Ok(users);
        }
    }
}
