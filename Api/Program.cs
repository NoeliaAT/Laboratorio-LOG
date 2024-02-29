using Api.Funcionalidades;
using Api.Funcionalidades.Domicilios;
using Api.Funcionalidades.Usuarios;
using Carter;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddServiceManager();
builder.Services.AddCarter();

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


// video 4 minuto 5:20//