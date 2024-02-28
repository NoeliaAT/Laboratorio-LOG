using Microsoft.AspNetCore.Mvc;
namespace Api.Funcionalidades.Domicilios;

public static class DomicilioEndPoints
{
    public static void MapDomicilioEndPoints(this WebApplication app)
    {
        app.MapGet("/api/domicilio", ([FromServices] IDomicilioService domicilioService) =>
        {
            return Results.Ok(domicilioService.GetDomicilios());
        });
    }
}