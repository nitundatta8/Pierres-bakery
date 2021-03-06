using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Treat
  {
    public int TreatId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public ICollection<FlavorTreat> Flavors { get; }
    public virtual ApplicationUser User { get; set; }

    public Treat()
    {
      this.Flavors = new HashSet<FlavorTreat>();
    }
  }
}