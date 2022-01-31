using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Drinks: Item
    {
        public string Name { get; set; }
        public int Liters { get; set; }

        public Drinks(string name, int liters, decimal price, int barCode, double weight) : base (price, barCode, weight)
        {
            Name = name;
            Liters = liters;
        }
    }
}
