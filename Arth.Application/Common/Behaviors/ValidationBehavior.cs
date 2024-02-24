using Arth.Application.Authentication.Commands.Register;
using Arth.Application.Authentication.Common;
using ErrorOr;
using FluentValidation;
using FluentValidation.Results;
using MediatR;

namespace Arth.Application.Common.Behaviors;

public class ValidationBehavior<TRequest, TResponse> :
    IPipelineBehavior<TRequest, TResponse>
    where TRequest : IRequest<TResponse>
    where TResponse : IErrorOr
{
    //If you have multiple validators, request them here
    private readonly IValidator<TRequest>? _validator;

    public ValidationBehavior(IValidator<TRequest>? validator = null)
    {
        _validator = validator;
    }

    public async Task<TResponse> Handle(
        TRequest request,
        RequestHandlerDelegate<TResponse> next,
        CancellationToken cancellationToken)
        //here you can iterate through validators and invoke all of them
    {
        if(_validator is null)
        {
            return await next();
        }

        //List of validation errors to convert to a list of Errors
        var validationResult = await _validator.ValidateAsync(
            request,
            cancellationToken);

        if (validationResult.IsValid)
        {
            return await next();
        }
        var errors = validationResult.Errors
            .ConvertAll(validationFailure => Error.Validation(
                validationFailure.PropertyName,
                validationFailure.ErrorMessage));

        return (dynamic)errors;
        //Since the compiler does not know theres a implicit converter from the list of errors to ErrorOr
        //object, dynamic on runtime will check if theres a way to do this conversion. Even if something exceptional
        //happens we still have our global error solution and now exception will be thrown
    }
}
