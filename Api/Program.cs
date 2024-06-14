using Api.Funcionalidades;
using Api.Persistencia;
using Carter;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddServiceManager();
builder.Services.AddCarter();

var connectionString = builder.Configuration.GetConnectionString("aplicacion_db");

builder.Services.AddDbContext<AplicacionDbContext>(opcion =>
    opcion.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 30))));

builder.Services.AddDbContext<AplicacionDbContext>();


var opciones = new DbContextOptionsBuilder<AplicacionDbContext>();

opciones.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 30)));

var contexto = new AplicacionDbContext(opciones.Options);

contexto.Database.EnsureCreated();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.MapUsuarioEndPoints();
//app.MapDomicilioEndPoints();

app.MapCarter();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


// video 4 minuto 29:00//
// revisar msql en casa, revisar version,  video 4 minuto 24:00 //
//code farce:  es código fuente, primero hago el código c# y después de ahi genera el sql
//daba base farce: a partir de una base de datos existente (con datos o no cargados), tiro el comando de linea para traerme la base de datos y automáticamente (Entity) lo convierte en c#