using CargoApp.Entities.Models;
using CargoApp.Map.Options;
using Microsoft.EntityFrameworkCore;

namespace CargoApp.Dal.Context;

public class CargoAppContext : DbContext
{
    public CargoAppContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Member> Members { get; set; }
    
    public DbSet<Shipping> Shippings { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
       
    }
}