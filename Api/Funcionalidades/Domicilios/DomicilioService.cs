using Aplicacion.Dominio;

namespace Api.Funcionalidades.Domicilios;   

public interface IDomicilioService
{
    List<Domicilio> GetDomicilios();
}

public class DomicilioService : IDomicilioService
{

    List<Domicilio> domicilios;

    public DomicilioService()
    {
        domicilios = new List<Domicilio>()
        {
            new Domicilio("Av.Cabildo", 1054, 1104),
            new Domicilio("Av.Libertador", 2120, 1104)
        };
    }

    List<Domicilio> IDomicilioService.GetDomicilios()
    {
        return domicilios;
    }
}