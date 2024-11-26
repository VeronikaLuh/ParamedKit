 using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RestMatch.API.Domain.Interfaces;
using RestMatch.API.Infrastructure.Data;
using RestMatch.API.Infrastructure.Repositories;

namespace RestMatch.API.Infrastructure.Extensions
{
    public static class ServicesExtensions
    {
        public static void ConfigureDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });
        }

        public static void ConfigureRepositories(this IServiceCollection services)
        {
            services.AddScoped<IRestaurantRepository, RestaurantRepository>();
            services.AddScoped<ICuisineTypeRepository, CuisineTypeRepository>();
            services.AddScoped<IRestaurantCriteriasRepository, RestaurantCriteriasRepository>();
            services.AddScoped<IUserSelectedCriteriasRepository, UserSelectedCriteriasRepository>();
            services.AddScoped<IReviewRepository, ReviewRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}
