
var builder = WebApplication.CreateBuilder(args);

// Configurando a extensão de configuração de banco de dados
builder.AddDapper();

// Atribuindo a configuração de serviços
builder.AddServices();

var app = builder.Build();
app.UserServices();
app.MapCarter();

app.Run();
