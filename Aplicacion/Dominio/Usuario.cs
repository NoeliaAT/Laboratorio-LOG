using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aplicacion.Dominio;

[Table("Usuario")]
public class Usuario
{
    [Required]
    [StringLength(50)]
    public string Nombre { get; set; } = string.Empty; 

    [Required]
    [StringLength(50)]
    public string Apellido { get; set; } = string.Empty;

    [Key]
    [Required]
    [StringLength(50)]
    public string Direccion { get; set; } = string.Empty;

    public Usuario(string nombre, string apellido, string direccion)
    {
        this.Nombre = nombre;
        this.Apellido = apellido;
        this.Direccion = direccion;
    }
}