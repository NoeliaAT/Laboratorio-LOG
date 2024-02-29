using Microsoft.AspNetCore.Mvc;
namespace Api.Funcionalidades.Domicilios;

public static class DomicilioEndPoints : ICarterModule 
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/api/domicilio", ([FromServices] IDomicilioService domicilioService) =>
        {
            return Results.Ok(domicilioService.GetDomicilios());
        });
    }
}
