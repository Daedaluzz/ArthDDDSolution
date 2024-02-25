using Arth.Application.Authentication.Common;
using Arth.Application.Common.Interfaces.Authentication;
using Arth.Application.Common.Interfaces.Persistence;
using Arth.Domain.Common.Errors;
using Arth.Domain.Entities;

using ErrorOr;

using MediatR;

namespace Arth.Application.Authentication.Commands.Register;

internal class RegisterCommandHandler :
    IRequestHandler<RegisterCommand, ErrorOr<AuthenticationResult>>
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly IUserRepository _userRepository;
    public RegisterCommandHandler(
        IJwtTokenGenerator jwtTokenGenerator,
        IUserRepository userRepository)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
        _userRepository = userRepository;
    }


    public async Task<ErrorOr<AuthenticationResult>> Handle(RegisterCommand command, CancellationToken cancellationToken)
    {
        //To fix generating a state machine even withou doing anything asyncronous
        await Task.CompletedTask;

        //Validating if the user dosn't exist
        if (_userRepository.GetUserByEmail(command.Email) is not null)
        {
            return Errors.Users.DuplicateEmail;
        }


        //Create user (generate unique ID) & persist to the DB
        var user = User.Create
        (
            command.FirstName,
            command.LastName,
            command.Email,
            command.Password
        );

        _userRepository.Add(user);

        //Create JWT token
        var token = _jwtTokenGenerator.GenerateToken(user);
        return new AuthenticationResult(
            user,
            token); ;
    }
}
