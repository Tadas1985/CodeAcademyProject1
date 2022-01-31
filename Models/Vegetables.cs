using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Vegetables: Item
    {
        public string Name { get; set; }
        public int Fiber { get; set; }

       

        public Vegetables(string name, int fiber, decimal price, int barCode, double weight):base (price, barCode, weight)
        {
            
        }

        public Vegetables(string name, int fiber)
        {
            Name = name;
            Fiber = fiber;
        }
    }
}
