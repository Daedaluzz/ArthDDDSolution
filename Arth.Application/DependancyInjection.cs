using Microsoft.Extensions.DependencyInjection;
using MediatR;

namespace Arth.Application
{
    public static class DependancyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(AppDomain.CurrentDomain.GetAssemblies())); ;
     
            return services;
        }
    }
}
