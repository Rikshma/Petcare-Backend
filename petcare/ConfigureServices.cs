using petcare.Application.Commands;
using petcare.Persistence.Repositories;

namespace petcare
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddRequiredServices(this IServiceCollection services,
        WebApplicationBuilder builder)
        {
            services.AddScoped<CreateNotificationCommand>();
            services.AddScoped<RegisterPetCommand>();
            services.AddScoped<LoginCommand>();

            //repositories
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IPetRepository, PetRepository>();
            services.AddScoped<INotificationRepository,NotificationRepository>();
            return services;
        }    
    }
}
