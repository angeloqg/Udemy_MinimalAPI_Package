
var builder = WebApplication.CreateBuilder(args);

// Configurando a extens�o de configura��o de banco de dados
builder.AddDapper();

// Atribuindo a configura��o de servi�os
builder.AddServices();

var app = builder.Build();
app.UserServices();
app.MapCarter();

app.Run();
