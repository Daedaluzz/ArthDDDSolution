using Arth.Application.Common.Interfaces.Authentication;
using Arth.Application.Common.Interfaces.Services;
using Arth.Infrastructure.Authentication;
using Arth.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Arth.Infrastructure

{
    public static class DependancyInjection
    {
        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services,
            Microsoft.Extensions.Configuration.ConfigurationManager configuration)
        {
            services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
            services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
            return services;
        }
    }
}
