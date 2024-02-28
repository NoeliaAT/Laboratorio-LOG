using Microsoft.AspNetCore.Mvc;
namespace Api.Funcionalidades.Usuarios;

public static class UsuarioEndPoints

{
    public static void MapUsuarioEndPoints(this WebApplication app)
    {
        app.MapGet("/api/usuario", ([FromServices] IUsuarioService usuarioService) =>
        {
            return Results.Ok(usuarioService.GetUsuarios());
        });
    }
}
