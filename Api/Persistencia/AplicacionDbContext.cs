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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Usuario>().HasData(
            new Usuario ("Usuario1", "ApellidoA", "Dirección1" ),
            new Usuario ("Usuario2", "ApellidoB", "Dirección2" )
        );

        modelBuilder.Entity<Domicilio>().HasData(
            new Domicilio ("Domicilio1", 1, 1 ),
            new Domicilio ("Domicilio2", 2, 2 )
        );
    }
}
