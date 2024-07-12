using Api.Persistencia;
using Aplicacion.Dominio;

namespace Api.Funcionalidades.Domicilios;   

public interface IDomicilioService
{
    void AddUsuarioToDomicilio(Guid usuarioId, Guid domicilioId);
    void CreateDomicilio(DomicilioDto domicilioDto);
    void DeleteDomicilio(Guid domicilioId);
    void DeleteUsuarioFromDomicilio(Guid usuarioId, Guid domicilioId);
    List<Domicilio> GetDomicilios();
    void UpdateDomicilio(Guid domicilioId, DomicilioDto domicilioDto);
}

public class DomicilioService : IDomicilioService
{
    private readonly AplicacionDbContext context;

    public DomicilioService(AplicacionDbContext context)
    {
        this.context = context;
    }

    public void AddUsuarioToDomicilio(Guid usuarioId, Guid domicilioId)
    {
        var usuario = context.Usuarios.FirstOrDefault(x => x.Id == usuarioId);

        var domicilio = context.Domicilios.FirstOrDefault(x => x.Id == domicilioId);

        if (usuario != null && domicilio != null)
        {
            domicilio.AgregarUsuario(usuario);

            context.SaveChanges();
        }
    }

    public void CreateDomicilio(DomicilioDto domicilioDto)
    {
        context.Domicilios.Add(new Domicilio(domicilioDto.Calle));

        context.SaveChanges();
    }

    public void DeleteDomicilio(Guid domicilioId)
    {
        var domicilio = context.Domicilios.FirstOrDefault(x => x.Id == domicilioId);

        if (domicilio != null)
        {
            context.Domicilios.Remove(domicilio);
            context.SaveChanges();
        }
    }

    public void DeleteUsuarioFromDomicilio(Guid usuarioId, Guid domicilioId)
    {
        
        var usuario = context.Usuarios.FirstOrDefault(x => x.Id == usuarioId);

        var domicilio = context.Domicilios.FirstOrDefault(x => x.Id == domicilioId);

        if (usuario != null && domicilio != null)
        {
            domicilio.BorrarUsuario(usuario);

            context.SaveChanges();
        }
    }

    public List<Domicilio> GetDomicilios()
    {
        return context.Domicilios.ToList();
    }

    public void UpdateDomicilio(Guid domicilioId, DomicilioDto domicilioDto)
    {
        var domicilio = context.Domicilios.FirstOrDefault(x => x.Id == domicilioId);

        if (domicilio != null)
        {
            domicilio.Calle = domicilioDto.Calle;
            context.SaveChanges();
        }
    }
}