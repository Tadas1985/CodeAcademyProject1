using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Candies: Item
    {
        public int Sugar;
        public string Name;
        
        

        public Candies(string name, int sugar, decimal price, int barCode, double weight): base (price, barCode, weight)
        {   Name = name;
            Sugar = sugar;
        }
       

        public override string ToString()
        {
            string srt = $"Name of item: {Name}, Amount of sugar: {Sugar}, price per unit: {Price}, barcode: {BarCode}, weight kg: {Weight} ";
            return srt;
        }
    }
}
