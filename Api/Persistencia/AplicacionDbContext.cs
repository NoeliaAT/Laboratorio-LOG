using Aplicacion.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Api.Persistencia;

public class AplicaciónDbContext : DbContext
{
    public AplicaciónDbContext(DbContextOptions<AplicaciónDbContext> opciones)
    : base(opciones)
    {
    }
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Domicilio> Domicilios { get; set; }
}
