using Microsoft.AspNetCore.Mvc;
using Api.Models;

namespace Api.Controllers;

public static class MapEndpointsConsumo
{
    public static void MapEndpointConsumo(this WebApplication app)
    {
       
        app.MapGet("/Api/Consumo", ([FromServices] AppDataContext ctx)
            => Results.Ok(ctx.Consumo.ToList()));

        
        app.MapGet("/Api/Consumo/{id:int}", ([FromRoute] int id, [FromServices] AppDataContext ctx) =>
        {
            var c = ctx.Consumo.Find(id);
            return c is null ? Results.NotFound("Consumo nao inserido") : Results.Ok(c);
        });

        
        app.MapPost("/Api/Consumo", ([FromBody] Consumo body, [FromServices] AppDataContext ctx) =>
        {
            ctx.Consumo.Add(body);
            ctx.SaveChanges();
            return Results.Created($"/Api/Consumo/{body.Id}", body);
        });

       
        app.MapPut("/Api/Consumo/{id:int}", ([FromRoute] int id, [FromBody] Consumo body, [FromServices] AppDataContext ctx) =>
        {
            var c = ctx.Consumo.Find(id);
            if (c is null) return Results.NotFound("Consumo nao inserido");

            c.Cpf = body.Cpf;
            c.Mes = body.Mes;
            c.Ano = body.Ano;
            c.M3Consumidos = body.M3Consumidos;
            c.Bandeira = body.Bandeira;
            c.PossuiEsgoto = body.PossuiEsgoto;

            ctx.SaveChanges();
            return Results.Ok(c);
        });

      
        app.MapDelete("/Api/Consumo/{id:int}", ([FromRoute] int id, [FromServices] AppDataContext ctx) =>
        {
            var c = ctx.Consumo.Find(id);
            if (c is null) return Results.NotFound("Consumo nao inserido");
            ctx.Consumo.Remove(c);
            ctx.SaveChanges();
            return Results.NoContent();
        });
    }
}