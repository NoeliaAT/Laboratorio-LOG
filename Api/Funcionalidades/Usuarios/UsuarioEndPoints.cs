using Microsoft.AspNetCore.Mvc;
namespace Api.Funcionalidades.Usuarios;

public static class UsuarioEndPoints : ICarterModule

{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/api/usuario", ([FromServices] IUsuarioService usuarioService) =>
        {
            return Results.Ok(usuarioService.GetUsuarios());
        });
    }
}
