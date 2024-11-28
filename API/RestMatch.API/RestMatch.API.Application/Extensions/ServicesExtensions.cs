using System;
using Microsoft.Extensions.DependencyInjection;
using RestMatch.API.Application.Interfaces;
using RestMatch.API.Application.Services;
using RestMatch.Azure.BlobStorage;

namespace RestMatch.API.Infrastructure.Extensions
{
    public static class ServicesExtensions
    {
        public static void ConfigureAutoMapper(this IServiceCollection services) =>
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddScoped<IRateService, RateService>();
            services.AddScoped<IRestaurantService, RestaurantService>();
            services.AddScoped<ICuisineTypeService, CuisineTypeService>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IFavouritesService, FavouritesService>();
            services.AddSingleton<IAzureStorage, AzureStorage>();
            services.AddScoped<IUserSelectedCriteriaService, UserSelectedCriteriaService>();
        }
    }
}
