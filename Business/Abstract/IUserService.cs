using Business.Request.User;
using Core.Entities;
using Core.Utilities.Security.JWT;

namespace Business.Abstract
{
    public interface IUserService
    {
        void Register(RegisterRequest request);
        AccessToken Login(LoginRequest request); //TODO: return type: JWT
        List<OperationClaim> GetClaims(User user);
        User GetByMail(string email);
    }
}
