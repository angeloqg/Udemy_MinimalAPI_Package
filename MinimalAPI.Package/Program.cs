

var builder = WebApplication.CreateBuilder(args);

// Configurando a extensão de configuração de banco de dados
builder.AddDapper();

var app = builder.Build();



app.Run();
