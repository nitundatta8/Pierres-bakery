using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PierresBakery.Models
{
  public class PierresBakeryContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet<Flavor> Flavors { get; set; }
    public DbSet<FlavorTreat> FlavorTreats { get; set; }
    public DbSet<Treat> Treats { get; set; }
    public PierresBakeryContext(DbContextOptions options) : base(options) { }
  }
}