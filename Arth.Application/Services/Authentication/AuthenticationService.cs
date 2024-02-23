
namespace Arth.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    public AuthenticationResult Register(string firstName, string lastName, string email, string password)
    {
        //Check if the user alredy exists

        //Create user (generate unique ID)

        //Create JWT token

        return new AuthenticationResult(Guid.NewGuid(), firstName, lastName, email, "token");
    }

    public AuthenticationResult Login(string email, string password)
    {
        return new AuthenticationResult(Guid.NewGuid(), "firstName", "lastName", email, "token");
    }
}
