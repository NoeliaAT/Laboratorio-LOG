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
        
    }

    public List<Usuario> GetUsuarios()
}


// video 2 minuto 13:00 //