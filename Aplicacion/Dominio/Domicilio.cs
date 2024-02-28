namespace Aplicacion.Dominio;

public class Domicilio
{
    public string Calle { get; set; } = string.Empty;
    public int Altura { get; set; }
    public int CodigoPostal { get; set; }
    public Domicilio(string calle, int altura, int codigoPostal)
    {
        this.Calle = calle;
        this.Altura = altura;
        this.CodigoPostal = codigoPostal;
    }
}
