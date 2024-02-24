using Microsoft.Extensions.DependencyInjection;
using MediatR;
using Arth.Application.Authentication.Commands.Register;
using Arth.Application.Authentication.Common;
using Arth.Application.Common.Behaviors;
using ErrorOr;

namespace Arth.Application
{
    public static class DependancyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(AppDomain.CurrentDomain.GetAssemblies()));
            services.AddScoped<
                IPipelineBehavior<RegisterCommand, ErrorOr<AuthenticationResult>>,
                ValidateRegisterCommandBehavior>();     
            return services;
        }
    }
}
