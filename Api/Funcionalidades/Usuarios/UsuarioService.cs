using Api.Persistencia;
using Aplicacion.Dominio;

namespace Api.Funcionalidades.Usuarios;   

public interface IUsuarioService
{
    void CreateUsuario(UsuarioCommandDto usuarioDto);
    void DeleteUsuario(Guid usuarioId);
    List<UsuarioQueryDto> GetUsuarios();
    void UpdateUsuario(Guid usuarioId, UsuarioCommandDto usuarioDto);
}

public class UsuarioService : IUsuarioService
{
    private readonly AplicacionDbContext context;

    public UsuarioService(AplicacionDbContext context)
    {
        this.context = context;
    }

    public void CreateUsuario(UsuarioCommandDto usuarioDto)
    {
        context.Usuarios.Add(new Usuario(usuarioDto.Nombre, usuarioDto.Apellido, usuarioDto.Direccion));

        context.SaveChanges();
    }

    public void DeleteUsuario(Guid usuarioId)
    {
        var usuario = context.Usuarios.FirstOrDefault(x => x.Id == usuarioId);

        if(usuario != null)
        {
            context.Usuarios.Remove(usuario);
            context.SaveChanges();
        }
    }

    public List<UsuarioQueryDto> GetUsuarios()
    {
        return context.Usuarios.Select(x => new UsuarioQueryDto { Id = x.Id, Nombre = x.Nombre, Apellido = x.Apellido, Direccion = x.Direccion }).ToList();
    }

    public void UpdateUsuario(Guid usuarioId, UsuarioCommandDto usuarioDto)
    {
        var usuario = context.Usuarios.FirstOrDefault(x => x.Id == usuarioId);

        if (usuario != null)
        {
            usuario.Nombre = usuarioDto.Nombre;
            usuario.Apellido = usuarioDto.Apellido;
            usuario.Direccion = usuarioDto.Direccion;
            context.SaveChanges();
        }
    }
}