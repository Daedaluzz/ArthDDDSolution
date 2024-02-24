using Arth.Application.Common.Interfaces.Authentication;
using Arth.Application.Common.Interfaces.Persistence;
using Arth.Application.Services.Authentication.Common;
using Arth.Domain.Common.Errors;
using Arth.Domain.Entities;
using ErrorOr;

namespace Arth.Application.Services.Authentication.Commands;

public class AuthenticationCommandService : IAuthenticationCommandService
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly IUserRepository _userRepository;

    public AuthenticationCommandService(IJwtTokenGenerator jwtTokenGenerator, IUserRepository userRepository)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
        _userRepository = userRepository;
    }

    public ErrorOr<AuthenticationResult> Register(string firstName, string lastName, string email, string password)
    {
        //Validating if the user dosn't exist
        if (_userRepository.GetUserByEmail(email) is not null)
        {
            return Errors.Users.DuplicateEmail;
        }


        //Create user (generate unique ID) & persist to the DB
        var user = new User
        {
            FirstName = firstName,
            LastName = lastName,
            Email = email,
            Password = password
        };

        _userRepository.Add(user);

        //Create JWT token
        var token = _jwtTokenGenerator.GenerateToken(user);

        return new AuthenticationResult(
            user,
            token);
    }

}
