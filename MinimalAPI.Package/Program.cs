

var builder = WebApplication.CreateBuilder(args);

// Configurando a extens�o de configura��o de banco de dados
builder.AddDapper();

var app = builder.Build();



app.Run();
