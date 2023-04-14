using CAPoliza.Aplicacion;
using CAPoliza.Infraestructura;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//registro de configuracion
ConfigurationManager configuration = builder.Configuration;



// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// Adicion de los servicios 
builder.Services.AddDbContext<PolizaDBcontext>(opt => opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly("PolizaAPI")));
builder.Services.AddScoped<IServicioPoliza, ServicioPoliza>();
builder.Services.AddScoped<IRepositorioPoliza, RepositorioPoliza>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
