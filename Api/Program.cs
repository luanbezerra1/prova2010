using Microsoft.EntityFrameworkCore;
using Wms.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder Build();

app.MapGet("/" , () => "Hello, Minimal API!")

app.MapEndpointConsumo();

app.Run();