using Business.Request.User;
using Core.Entities;
using Core.Utilities.Security.JWT;

namespace Business.Abstract
{
    public interface IAuthService
    {
        void Register(RegisterRequest request, string password);
        AccessToken Login(LoginRequest request);
        void UserExists(string email);
        AccessToken CreateAccessToken(User user);
    }
}
