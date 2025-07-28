using ecommerce.Application.DTOs.Request;
using ecommerce.Application.Interfaces;
using ecommerce.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ecommerce.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task<Users> UserCreate([FromBody] UserRequest req)
        {
            return await _userService.UserCreate(req);
        }
    }
}
