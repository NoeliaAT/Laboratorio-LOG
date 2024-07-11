using Api.Persistencia;
using Aplicacion.Dominio;

namespace Api.Funcionalidades.Domicilios;   

public interface IDomicilioService
{
    List<Domicilio> GetDomicilios();
}

public class DomicilioService : IDomicilioService
{
    private readonly AplicacionDbContext context;

    public DomicilioService(AplicacionDbContext context)
    {
        this.context = context;
    }

    public List<Domicilio> GetDomicilios()
    {
        return context.Domicilios.ToList();
    }
}