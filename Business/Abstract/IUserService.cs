using Business.Request.User;

namespace Business.Abstract
{
    public interface IUserService
    {
        void Register(RegisterRequest request);
        bool Login(LoginRequest request); //TODO: return type: JWT
    }
}
