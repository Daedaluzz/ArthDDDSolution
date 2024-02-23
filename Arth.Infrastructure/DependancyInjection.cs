using Arth.Application.Common.Interfaces.Authentication;
using Arth.Infrastructure.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace Arth.Infrastructure

{
    public static class DependancyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
            return services;
        }
    }
}
