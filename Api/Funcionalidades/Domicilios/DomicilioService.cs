using Api.Funcionalidades.Usuarios;
using Api.Persistencia;
using Aplicacion.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Api.Funcionalidades.Domicilios;   

public interface IDomicilioService
{
    void AddUsuarioToDomicilio(Guid usuarioId, Guid domicilioId);
    void CreateUsuario(DomicilioCommandDto domicilioDto);
    void DeleteUsuario(Guid domicilioId);
    void DeleteUsuarioFromDomicilio(Guid usuarioId, Guid domicilioId);
    List<DomicilioQueryDto> GetDomicilios();
    void UpdateDomicilio(Guid domicilioId, DomicilioCommandDto domicilioDto);
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

    public void CreateUsuario(DomicilioCommandDto domicilioDto)
    {
        context.Domicilios.Add(new Domicilio(domicilioDto.Calle));

        context.SaveChanges();
    }

    public void DeleteUsuario(Guid domicilioId)
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

    public List<DomicilioQueryDto> GetDomicilios()
    {
        return context.Domicilios.
        Include(x => x.Usuarios)
        .Select(x => new DomicilioQueryDto
        { 
            Id = x.Id,
            Calle = x.Calle,
            Altura = x.Altura,
            CodigoPostal = x.CodigoPostal,
            Usuarios = x.Usuarios.Select(y => new UsuarioQueryDto { Id = y.Id, Nombre = y.Nombre, Apellido = y.Apellido, Direccion = y.Direccion }).ToList()
        }).ToList();
    }

    public void UpdateDomicilio(Guid domicilioId, DomicilioCommandDto domicilioDto)
    {
        var domicilio = context.Domicilios.FirstOrDefault(x => x.Id == domicilioId);

        if (domicilio != null)
        {
            domicilio.Calle = domicilioDto.Calle;
            context.SaveChanges();
        }
    }
}