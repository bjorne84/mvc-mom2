using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc_mom2.Models
{
    public class Skoter
    {
        
        public string Make { get; set; }
        public string Model { get; set; }


        public Skoter() {}

        public Skoter(string make, string model)
        {
            this.Make = make;
            this.Model = model;
        }
    }
    public class ViewModel
    {
        public IEnumerable<Skoter> SkoterLista { get; set; }
    }

}
