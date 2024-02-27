namespace Aplicacion.Dominio;

public class Paquete
{
    public Guid idPaquete { get; set; } =Guid.NewGuid();
    public int Peso { get; set; }
    public float Altura { get; set; }
    public float Ancho { get; set; }
    public float Largo { get; set; }
}
