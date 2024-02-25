using Business.Abstract;
using Business.Request.User;
using Core.Utilities.Security.JWT;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public AccessToken Login(LoginRequest request)
        {
            return _authService.Login(request);
        }

        [HttpPost("register")]
        public void Register(RegisterRequest request)
        {
            _authService.Register(request, request.Password);
        }
    }
}
