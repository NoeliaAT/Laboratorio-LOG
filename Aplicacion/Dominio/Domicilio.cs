using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aplicacion.Dominio;

[Table("Domicilio")]
public class Domicilio
{
    
    [Key]
    [Required]
    public Guid Id { get; set; } = Guid.NewGuid();
    
    [Required]
    [StringLength(50)]
    public string Calle { get; set; } = string.Empty;

    [Required]
    [StringLength(50)]
    public int Altura { get; set; }

    [Required]
    public int CodigoPostal { get; set; }

    public List<Usuario> Usuarios {get; set; } =  new List<Usuario>();

    public Domicilio(string calle, int altura, int codigoPostal)
    {
        this.Calle = calle;
        this.Altura = altura;
        this.CodigoPostal = codigoPostal;
    }

    public Domicilio(string calle)
    {
        Calle = calle;
    }

    public void AgregarUsuario(Usuario usuario) => Usuarios.Add(usuario);

    public void BorrarUsuario(Usuario usuario) => Usuarios.Remove(usuario);
}