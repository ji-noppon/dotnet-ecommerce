using ecommerce.Application.Interfaces;
using ecommerce.Application.Services;
using ecommerce.Domain.Interfaces;
using ecommerce.Infrastructure.Repositories;

namespace ecommerce.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            // register service ต่าง ๆ
            services.AddScoped<IUserRepository, UserRepository>();

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IAuthenService, AuthenService>();
            return services;
        }
    }
}
