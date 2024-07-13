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
        

        app.MapPost("/api/domicilio", ([FromServices] IDomicilioService domicilioService, DomicilioCommandDto domicilioDto) =>
        {
            domicilioService.CreateUsuario(domicilioDto);

            return Results.Ok();
        });

        app.MapPut("/api/domicilio/{domicilioId}", ([FromServices] IDomicilioService domicilioService,Guid domicilioId, DomicilioCommandDto domicilioDto) =>
        {
            domicilioService.UpdateDomicilio(domicilioId, domicilioDto);

            return Results.Ok();
        });

        app.MapDelete("/api/domicilio/{domicilioId}", ([FromServices] IDomicilioService domicilioService,Guid domicilioId) =>
        {
            domicilioService.DeleteUsuario(domicilioId);

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
