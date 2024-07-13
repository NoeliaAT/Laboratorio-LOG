using Carter;
using Microsoft.AspNetCore.Mvc;

namespace Api.Funcionalidades.Usuarios;
public class UsuarioEndPoints : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/api/usuario", ([FromServices] IUsuarioService usuarioService) =>
        {
            return Results.Ok(usuarioService.GetUsuarios());
        });

        app.MapPost("/api/usuario", ([FromServices] IUsuarioService usuarioService, UsuarioCommandDto usuarioDto) =>
        {
            usuarioService.CreateUsuario(usuarioDto);

            return Results.Ok();
        });

        app.MapPut("/api/usuario/{usuarioId}", ([FromServices] IUsuarioService usuarioService,Guid usuarioId, UsuarioCommandDto usuarioDto) =>
        {
            usuarioService.UpdateUsuario(usuarioId, usuarioDto);

            return Results.Ok();
        });

        app.MapDelete("/api/usuario/{usuarioId}", ([FromServices] IUsuarioService usuarioService,Guid usuarioId) =>
        {
            usuarioService.DeleteUsuario(usuarioId);

            return Results.Ok();
        });
    }
}
