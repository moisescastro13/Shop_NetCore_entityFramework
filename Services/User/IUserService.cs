using Models.Request;
using Models.Respose;

namespace Services.User
{
    public interface IUserService
    {
        LoginResponse SignIn(SignInDto credential);
        LoginResponse SignUp(SignUpDto credential);
    }
}