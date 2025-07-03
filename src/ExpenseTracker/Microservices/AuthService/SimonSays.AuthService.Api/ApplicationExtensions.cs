namespace SimonSays.AuthService.Api
{
    public static class ApplicationExtensions
    {
        public static IServiceCollection AddAuthServiceApplications(this IServiceCollection services)
        {
            services.AddScoped<Application.Interfaces.IUserService, Application.Services.UserService>();
            services.AddScoped<Application.Interfaces.IUserRepository, Infrastructure.UserRepository>();
            return services;
        }
    }
} 