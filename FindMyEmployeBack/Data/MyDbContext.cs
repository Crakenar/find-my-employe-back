using FindMyEmployeBack.Model;
using FindMyEmployeBack.Types;
using Microsoft.EntityFrameworkCore;

namespace FindMyEmployeBack.Data;

public class MyDbContext : DbContext
{
    private readonly IConfiguration _configuration;
    
    public MyDbContext()
    {
        
    }
    public MyDbContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
       // _configuration.GetConnectionString("ConnectionStrings.DefaultConnection")
       // _configuration.GetConnectionString("DefaultConnection")
        optionsBuilder.UseMySql("server=localhost;user=root;database=FindMyEmployee;password=123;port=3306",
            ServerVersion.AutoDetect( "server=localhost;user=root;database=FindMyEmployee;password=123;port=3306")
            );
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<LocalizationType>().HasData(
            new LocalizationType(1, "Grenoble"),
            new LocalizationType(2, "Paris"),
            new LocalizationType(3, "Toulouse"),
            new LocalizationType(4, "Marseille"),
            new LocalizationType(5, "Lyon"),
            new LocalizationType(6, "Perpignan"),
            new LocalizationType(7, "Lille")
        );
    }
    
    //Entities
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Company> Companies { get; set; }
}