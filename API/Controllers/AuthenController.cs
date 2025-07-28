using ecommerce.Application.DTOs.Request;
using ecommerce.Application.Interfaces;
using ecommerce.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ecommerce.API.Controllers
{
    [ApiController]
    [Route("api/v1/auth")]
    public class AuthenController : Controller
    {
        private readonly IAuthenService _userService;
        public AuthenController(IAuthenService userService)
        {
            _userService = userService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest req)
        {
            try
            {
                var isLogin = await _userService.Login(req);
                if (isLogin)
                {
                    return Ok(new { message = "success" });
                } else
                {
                    return Unauthorized(new { message = "login failed" });
                }
            } 
            catch (Exception ex)
            {
                return Unauthorized(new { message = ex.Message });
            }
        }
    }
}
