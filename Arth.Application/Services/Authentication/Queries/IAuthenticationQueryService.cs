using Arth.Application.Services.Authentication.Common;
using ErrorOr;

namespace Arth.Application.Services.Authentication.Queries;

public interface IAuthenticationQueryService
{
    ErrorOr<AuthenticationResult> Login(string email, string password);
}
