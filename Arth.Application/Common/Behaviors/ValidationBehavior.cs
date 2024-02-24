using Arth.Application.Authentication.Commands.Register;
using Arth.Application.Authentication.Common;
using ErrorOr;
using MediatR;

namespace Arth.Application.Common.Behaviors;

public class ValidateRegisterCommandBehavior :
    IPipelineBehavior<RegisterCommand, ErrorOr<AuthenticationResult>>
{
    public async Task<ErrorOr<AuthenticationResult>> Handle(
        RegisterCommand request,
        RequestHandlerDelegate<ErrorOr<AuthenticationResult>> next,
        CancellationToken cancellationToken)
    {
        //logic invoked before the handler
        var result = await next();
        //logic invoked after the handler
        return result;
    }
}
