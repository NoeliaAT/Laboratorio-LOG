namespace Api.Funcionalidades.Usuarios;

public class UsuarioCommandDto
{
    public required string Nombre {get; set; }
    public required string Apellido {get; set; }
    public required string Direccion {get; set; }
}

public class UsuarioQueryDto
{
    public required Guid Id {get; set; }
    public required string Nombre {get; set; } = string.Empty; 
    public required string Apellido {get; set; } = string.Empty;
    public required string Direccion {get; set; } = string.Empty;
}