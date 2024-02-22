using Arth.Application.Services.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace Arth.Application
{
    public static class DependancyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IAuthenticationService, AuthenticationService>();
            return services;
        }
    }
}
