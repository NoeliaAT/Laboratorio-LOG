using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aplicacion.Dominio;

[Table("Usuario")]
public class Usuario
{
    
    [Key]
    [Required]
    public Guid Id { get; set; } = Guid.NewGuid();
    
    [Required]
    [StringLength(50)]
    public string Nombre { get; set; } = string.Empty; 

    [Required]
    [StringLength(50)]
    public string Apellido { get; set; } = string.Empty;

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