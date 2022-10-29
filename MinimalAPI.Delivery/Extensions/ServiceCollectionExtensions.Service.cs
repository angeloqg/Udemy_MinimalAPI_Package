
namespace MinimalAPI.Delivery.Extensions
{
    public static partial class ServiceCollectionExtensions
    {
        public static WebApplicationBuilder AddServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddCors();
            builder.Services.AddCarter();

            return builder;
        }

        public static IApplicationBuilder UserServices(this IApplicationBuilder app)
        {
            app.UseCors(c =>
            {
                c.AllowAnyMethod();
                c.AllowAnyHeader();
                c.AllowCredentials();
                c.SetIsOriginAllowed((Host) => true);
            });
            return app;
        }
    }
}
