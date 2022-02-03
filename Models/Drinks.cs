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
        public override string ToString()
        {
            return $"{this.Name},{this.Liters},{this.Price},{this.BarCode},{this.Weight}";
        }

        public string ToString(string lineFormatting)
        {
            return String.Format(lineFormatting, this.Name,this.Liters,this.Price, this.BarCode, this.Weight);
                                                
                                                
                                                 
                                                 
        }
    }
}
