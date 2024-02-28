namespace Aplicacion.Dominio;

public class Usuario
{
    public string Nombre { get; set; } = string.Empty; 
    public string Apellido { get; set; } = string.Empty;
    public string Direccion { get; set; } = string.Empty;

    public Usuario(string nombre, string apellido, string direccion)
    {
        this.Nombre = nombre;
        this.Apellido = apellido;
        this.Direccion = direccion;
    }
}