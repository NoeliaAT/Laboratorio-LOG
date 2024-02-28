using Aplicacion.Dominio;

namespace Api.Funcionalidades.Usuarios;   

public interface IUsuarioService
{
    List<Usuario> GetUsuarios();
}

public class UsuarioService : IUsuarioService
{
    List<Usuario> usuarios;

    public UsuarioService()
    {
        usuarios = new List<Usuario>()
        {
            new Usuario("Maria", "Mar", "Av.Cabildo"),
            new Usuario("Juan", "Mar", "Av.Libertador")
        };
    }

    public List<Usuario> GetUsuarios()
    {
        return usuarios;
    }
}
