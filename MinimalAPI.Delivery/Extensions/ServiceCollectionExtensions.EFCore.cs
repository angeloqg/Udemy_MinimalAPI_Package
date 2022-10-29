using Microsoft.EntityFrameworkCore;

namespace MinimalAPI.Delivery.Extensions
{
    public static partial class ServiceCollectionExtensions
    {
        public static IServiceCollection AddEFCore(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DeliveryContext>(opt => 
            opt.UseSqlServer(configuration.GetConnectionString("SQL")));

            return services;
        }
    }

}
