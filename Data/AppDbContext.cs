using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    // public DbSet<WeatherForecast> WeatherForecasts { get; set; }
    // public DbSet<>
    
}