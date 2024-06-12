using Aplicacion.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Api.Persistencia;

public class AplicacionDbContext : DbContext
{
    public AplicacionDbContext(DbContextOptions<AplicacionDbContext> opciones)
    : base(opciones)
    {
    }
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Domicilio> Domicilios { get; set; }
}
