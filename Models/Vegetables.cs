using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Vegetables : Item
    {
        public string Name { get; set; }
        public int Fiber { get; set; }



        public Vegetables(string name, int fiber, decimal price, int barCode, double weight) : base(price, barCode, weight)
        {

        }

        public override string ToString()
        {
            return $"{this.Name},{this.Fiber},{this.Price},{this.BarCode},{this.Weight}";
        }

        public string ToString(string lineFormatting)
        {
            return String.Format(lineFormatting, this.Name, this.Fiber, this.Price, this.BarCode, this.Weight);




        }
    }
}