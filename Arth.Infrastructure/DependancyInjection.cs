using Arth.Application.Common.Interfaces.Authentication;
using Arth.Application.Common.Interfaces.Persistence;
using Arth.Application.Common.Interfaces.Services;
using Arth.Infrastructure.Authentication;
using Arth.Infrastructure.Persistence;
using Arth.Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Arth.Infrastructure

{
    public static class DependancyInjection
    {
        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services,
            ConfigurationManager configuration)
        {
            services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));

            services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
            services.AddSingleton<IDateTimeProvider, DateTimeProvider>();

            services.AddScoped<IUserRepository, UserRepository>();
            return services;
        }
    }
}
