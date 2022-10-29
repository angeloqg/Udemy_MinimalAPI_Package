var builder = WebApplication.CreateBuilder(args);

// Configurando o Swagger
builder.AddOpenAPI();

// Atribuindo a configuração de serviços
builder.AddServices();

var app = builder.Build();

app.UserServices();
app.MapCarter();
app.UseOpenAPI(String.Empty);

app.Run();
