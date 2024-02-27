namespace Aplicacion.Dominio;

public class Envio
{
    public Guid idpaquete { get; set; } = Guid.NewGuid();
    public  List<Remitente>Remitentes { get; set; } = new List<Remitente>();
    public  List<Destinatario> Destinatarios { get; set; } = new List<Destinatario>();
    public List<Sucursal> Sucursales { get; set; } = new List<Sucursal>();
    public int nroenvio;
}
