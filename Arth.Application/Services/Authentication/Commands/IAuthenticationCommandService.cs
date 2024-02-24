using Arth.Application.Services.Authentication.Common;
using ErrorOr;

namespace Arth.Application.Services.Authentication.Commands;

public interface IAuthenticationCommandService
{
    ErrorOr<AuthenticationResult> Register(string firstName, string lastName, string email, string password);
    
}
