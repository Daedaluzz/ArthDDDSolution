using Arth.Application.Authentication.Common;
using Arth.Application.Authentication.Queries.Login;
using Arth.Application.Common.Interfaces.Authentication;
using Arth.Application.Common.Interfaces.Persistence;
using Arth.Domain.Common.Errors;
using Arth.Domain.Entities;
using ErrorOr;
using MediatR;

namespace Arth.Application.Authentication.Commands.Login;

public class LoginQueryHandler :
    IRequestHandler<LoginQuery, ErrorOr<AuthenticationResult>>
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly IUserRepository _userRepository;
    public LoginQueryHandler(
        IJwtTokenGenerator jwtTokenGenerator,
        IUserRepository userRepository)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
        _userRepository = userRepository;
    }

    public async Task<ErrorOr<AuthenticationResult>> Handle(LoginQuery query, CancellationToken cancellationToken)
    {
        //To fix generating a state machine even withou doing anything asyncronous
        await Task.CompletedTask;

        // Validating if the user exists
        if (_userRepository.GetUserByEmail(query.Email) is not User user)
        {
            return Errors.Authentication.InvalidCredentials;
        }

        // Validating the password
        if (user.Password != query.Password)
        {
            return Errors.Authentication.InvalidCredentials;
        }

        //Creating Jwt token
        var token = _jwtTokenGenerator.GenerateToken(user);

        return new AuthenticationResult(
            user,
            token);
    }
}
