using Microsoft.EntityFrameworkCore;
using WebApiPrueba.Business;
using WebApiPrueba.Interfaces;
using WebApiPrueba.UnitWork;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Configura la conexión a la base de datos SQLite en memoria
builder.Services.AddDbContext<VikingContext>(options =>
    options.UseSqlite("Data Source=vikingos.db"));

// Agregar otros servicios necesarios
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<VikingoService>();

// Configuración de Swagger/OpenAPI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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

// Inicializa la base de datos en memoria
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<VikingContext>();
    await context.InicializarBaseDeDatos(); 
}

app.Run();