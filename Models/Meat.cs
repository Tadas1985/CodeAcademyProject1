using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Meat : Item
    {
        public string Name { get; set; }
        public int Protein { get; set; }

        public Meat(string name, int protein, decimal price, int barCode, double weight) : base(price, barCode, weight)
        {
            Name = name;
            Protein = protein;
        }

    }      
}
