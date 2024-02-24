using MediatR;
using ErrorOr;
using Arth.Application.Authentication.Common;

namespace Arth.Application.Authentication.Queries.Login;

public record LoginQuery(

    string Email,
    string Password) : IRequest<ErrorOr<AuthenticationResult>>;
