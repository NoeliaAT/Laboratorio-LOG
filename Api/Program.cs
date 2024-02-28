using Api.Funcionalidades.Domicilios;
using Api.Funcionalidades.Usuarios;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IUsuarioService, UsuarioService> ();
builder.Services.AddSingleton<IDomicilioService, DomicilioService> ();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapUsuarioEndPoints();
app.MapDomicilioEndPoints();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


// video 2 minuto 32//