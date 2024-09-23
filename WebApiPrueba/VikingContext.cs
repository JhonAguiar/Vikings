using Microsoft.EntityFrameworkCore;
using SharedModels;

public class VikingContext : DbContext
{
    public DbSet<Viking> Vikingos { get; set; }

    public VikingContext(DbContextOptions<VikingContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Viking>().ToTable("Vikingos");
    }

    public async Task InicializarBaseDeDatos()
    {
        await Database.OpenConnectionAsync();
        await Database.EnsureCreatedAsync();

        // Agregar datos de prueba
        if (!await Vikingos.AnyAsync())
        {
            Vikingos.Add(new Viking
            {
                // Inicializa las propiedades del vikingo
                Nombre = "Ragnar",
                NumeroBatallasGanadas = 5,
                TipoArmaFavorita = "Hacha",
                NivelHonor = "Alto",
                CausaMuerteGloriosa = "Batalla gloriosa",
                Clasificacion = "Guerreros de Thor"
            });
            await SaveChangesAsync();
        }
    }
}