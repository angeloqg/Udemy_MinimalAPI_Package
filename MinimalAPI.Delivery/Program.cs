var builder = WebApplication.CreateBuilder(args);

// Configurando o Swagger
builder.AddOpenAPI();

// Atribuindo a configuração de serviços
builder.AddServices();

// Configurando o EFCore
builder.Services.AddEFCore(builder.Configuration);

var app = builder.Build();

app.UserServices();
app.MapCarter();
app.UseOpenAPI(String.Empty);

await app.MigrateData();

app.Run();
