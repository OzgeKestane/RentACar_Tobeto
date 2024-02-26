using Business.Abstract;
using Business.Request.User;
using Core.Entities;
using Core.Utilities.Security.Hashing;
using Core.Utilities.Security.JWT;

namespace Business.Concrete
{
    public class AuthManager : IAuthService
    {
        private readonly IUserService _userService;
        private readonly ITokenHelper _tokenHelper;

        public AuthManager(IUserService userService, ITokenHelper tokenHelper)
        {
            _userService = userService;
            _tokenHelper = tokenHelper;
        }

        public AccessToken CreateAccessToken(User user)
        {
            var claims = _userService.GetClaims(user);
            var accessToken = _tokenHelper.CreateToken(user, claims);
            return new AccessToken();
        }

        public AccessToken Login(LoginRequest request)
        {
            User user = new();
            var claims = _userService.GetClaims(user);
            var userToCheck = _userService.GetByMail(request.Email);
            if (userToCheck == null)
            {
                throw new Exception("Kullanıcı bulunamadı");
            }

            if (!HashingHelper.VerifyPassword(request.Password, userToCheck.PasswordHash, userToCheck.PasswordSalt))
            {
                throw new Exception("Parola hatası");
            }
            return _tokenHelper.CreateToken(userToCheck, claims);
        }

        public void Register(RegisterRequest request, string password)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
            var user = new User
            {
                Email = request.Email,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Approved = true
            };
            _userService.Register(request);
        }

        public void UserExists(string email)
        {
            if (_userService.GetByMail(email) != null)
            {
                throw new Exception("Kullanıcı mevcut");
            }

        }
    }
}
