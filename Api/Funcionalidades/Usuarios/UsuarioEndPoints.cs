using System;
namespace Api.Funcionalidades.Usuarios;

public static class UsuarioEndPoints

{
    public static void AddUsuarioEndPoints(this WebApplication app)
    {
        app.MapGet("/Api/usuario", (UsuarioService usuarioService) =>
        {
            return Results.Ok(usuarioService.GetUsuarios());
        });
    }
}
