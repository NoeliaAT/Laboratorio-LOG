namespace Aplicacion.Dominio;

public class Sucursal
{
    public Guid  idSucursal { get; set; }= Guid.NewGuid();
    public string Nombre { get; set; } = string.Empty;
    public string DomicilioSucursal { get; set; } = string.Empty;
}