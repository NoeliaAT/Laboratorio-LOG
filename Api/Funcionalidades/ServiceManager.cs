using Api.Funcionalidades.Domicilios;
using Api.Funcionalidades.Usuarios;

namespace Api.Funcionalidades
{
    public static class ServiceManager
    {
            public static IServiceCollection AddServiceManager(this IServiceCollection services)
            {
                services.AddScoped<IUsuarioService, UsuarioService> ();
                services.AddScoped<IDomicilioService, DomicilioService> ();

                return services;
            }

    }
}

//tenemos 3 formas de definir un objeto
//Singleton es un solo objeto durante toda la ejecución de la aplicación
//Scoped solo se va a crear a medida que llegue un request y luego se elimina
//Transend cada vez que cambie de request sino también llamado a otro metodo se va a crear un nuevo objeto