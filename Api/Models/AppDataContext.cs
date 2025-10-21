using Microsoft.EntityFrameworkCore;
using Api.Models;

public class AppDataContext : DbContext
{
    public DbSet<Consumo> Consumo {get;set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=Luan2_Natan2.db");
    }
}
