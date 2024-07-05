using Api.Persistencia;
using Aplicacion.Dominio;

namespace Api.Funcionalidades.Usuarios;   

public interface IUsuarioService
{
    List<Usuario> GetUsuarios();
}

public class UsuarioService : IUsuarioService
{
    private readonly AplicacionDbContext context;

    public UsuarioService(AplicacionDbContext context)
    {
        this.context = context;
    }

    public List<Usuario> GetUsuarios()
    {
        return context.Usuarios.ToList();
    }
}