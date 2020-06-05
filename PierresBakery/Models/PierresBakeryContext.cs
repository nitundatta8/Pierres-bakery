using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PierresBakery.Models
{
  public class PierresBakeryContext : IdentityDbContext<ApplicationUser>
  {



    public PierresBakeryContext(DbContextOptions options) : base(options) { }
  }
}