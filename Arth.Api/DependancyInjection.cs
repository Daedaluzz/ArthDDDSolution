using Arth.Api.Common.Errors;
using Arth.Api.Common.Mapping;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace Arth.Api
{
    public static class DependancyInjection
    {
        public static IServiceCollection AddPresentation(this IServiceCollection services)
        {
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            services.AddSingleton<ProblemDetailsFactory, ArthProblemDetailsFactory>();
            services.AddMappings();
            return services;
        }
    }
}
