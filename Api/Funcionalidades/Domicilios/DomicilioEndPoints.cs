using Carter;
using Microsoft.AspNetCore.Mvc;

namespace Api.Funcionalidades.Domicilios;

public class DomicilioEndPoints : ICarterModule 
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/api/domicilio", ([FromServices] IDomicilioService domicilioService) =>
        {
            return Results.Ok(domicilioService.GetDomicilios());
        });
        

        app.MapPost("/api/domicilio", ([FromServices] IDomicilioService domicilioService, DomicilioDto domicilioDto) =>
        {
            domicilioService.CreateDomicilio(domicilioDto);

            return Results.Ok();
        });

        app.MapPut("/api/domicilio/{domicilioId}", ([FromServices] IDomicilioService domicilioService,Guid domicilioId, DomicilioDto domicilioDto) =>
        {
            domicilioService.UpdateDomicilio(domicilioId, domicilioDto);

            return Results.Ok();
        });

        app.MapDelete("/api/domicilio/{domicilioId}", ([FromServices] IDomicilioService domicilioService,Guid domicilioId) =>
        {
            domicilioService.DeleteDomicilio(domicilioId);

            return Results.Ok();
        });

        app.MapPost("/api/domicilio/{domicilioId}/usuario/{usuarioId}", ([FromServices] IDomicilioService domicilioService,Guid domicilioId,Guid usuarioId) =>
        {
            domicilioService.AddUsuarioToDomicilio(usuarioId, domicilioId);

            return Results.Ok();
        });

        app.MapDelete("/api/domicilio/{domicilioId}/usuario/{usuarioId}", ([FromServices] IDomicilioService domicilioService,Guid domicilioId,Guid usuarioId) =>
        {
            domicilioService.DeleteUsuarioFromDomicilio(usuarioId, domicilioId);

            return Results.Ok();
        });
    }
}
