using Microsoft.EntityFrameworkCore;

namespace MinimalAPI.Delivery.Module
{
    public class DeliveryModule : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapGet("/delivery/{packageId}/history", async (int packageId, DeliveryContext db) => 
                await db.Locations.Where(x => x.Id == packageId).OrderByDescending(x => x.Id).ToArrayAsync());


            app.MapPost("/delivery", async (DeliveryContext db, PackageLocation dto) => 
            {
                db.Locations.Add(new Location()
                {
                    Id = dto.Id,
                    Latitude = dto.Latitude,
                    Longitude = dto.Longitude
                });
                
                await db.SaveChangesAsync();

                return Results.Created($"/delivery/{dto.Id}",dto);
            });
        }
    }
}
