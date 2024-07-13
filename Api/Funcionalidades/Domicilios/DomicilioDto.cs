using Api.Funcionalidades.Usuarios;
using Aplicacion.Dominio;

namespace Api.Funcionalidades.Domicilios;

public class DomicilioCommandDto
{
    public required string Calle {get; set; }
}

public class DomicilioQueryDto
{
    public required Guid Id {get; set; }
    public required string Calle {get; set; } = string.Empty;
    public required int Altura {get; set; }
    public required int CodigoPostal {get; set; }

    public List<UsuarioQueryDto> Usuarios {get; set; } = new List<UsuarioQueryDto>();
}
