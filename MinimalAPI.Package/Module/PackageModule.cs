using Dapper;
using System.Data.SqlClient;

namespace MinimalAPI.Package.Module
{
    public class PackageModule : ICarterModule
    {
        public async void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapGet("/package", async(SqlConnection db) => 
                await db.QueryAsync("select * from package"));

            app.MapGet("/package/{code}", async (SqlConnection db, string code) => 
                await db.QueryFirstAsync("select * from package where code = @code", new { code})
            );

            app.MapPost("/package", async (SqlConnection db, RegisterPackageDto dto) =>
            {
                var newPackage = await db.QueryFirstOrDefaultAsync<RegisterPackageDto>
                (
                    @"insert into package(code, country, description)
                      output inserted.*
                      values(@code, @country, @description)", dto);

                return Results.Created($"/package/{newPackage.PackageId}", newPackage);

            });
        }
    }
}
