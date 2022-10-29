var builder = WebApplication.CreateBuilder(args);

// Configurando o Swagger
builder.AddOpenAPI();

var app = builder.Build();
app.UseOpenAPI(String.Empty);

app.Run();
