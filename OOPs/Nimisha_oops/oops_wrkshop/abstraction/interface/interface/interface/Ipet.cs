using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
  public interface Ipet
    {
        string Name { get; set; }
        int Age { get; set; }
        string Breed { get; set; }
        string Color { get; set; }
    }
}
