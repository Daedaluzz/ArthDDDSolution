using Arth.Application.Services.Authentication.Commands;
using Arth.Application.Services.Authentication.Queries;
using Microsoft.Extensions.DependencyInjection;

namespace Arth.Application
{
    public static class DependancyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IAuthenticationCommandService, AuthenticationCommandService>();
            services.AddScoped<IAuthenticationQueryService, AuthenticationQueryService>();
            return services;
        }
    }
}
