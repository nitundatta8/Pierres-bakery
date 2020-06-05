using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Flavor
  {
    public int FlavorId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public ICollection<FlavorTreat> Treats { get; set; }

    public Flavor()
    {
      this.Treats = new HashSet<FlavorTreat>();
    }
  }
}
