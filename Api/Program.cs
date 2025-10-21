var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDataContext>();

var app = builder.Build();

app.MapEndpointConsumo(); // <- sem isso, 404 em todas as rotas

app.Run();