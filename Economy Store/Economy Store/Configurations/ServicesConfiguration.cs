using ES.Services.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace ES.Web.Configurations
{
   public static class ServicesConfiguration
   {
      public static IServiceCollection ServicesConfigurations(this IServiceCollection services)
      {
         services
            .AddScoped<IProductService, ProductService>();
         return services;
      }
   }
}