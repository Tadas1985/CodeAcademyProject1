using System;

namespace Models
{
    public class Item
    {
        public Item(decimal price, int barCode, double weight)
        {
            Price = price;
            BarCode = barCode;
            Weight = weight;
        }

        public decimal Price { get; set; }
        public int BarCode { get; set; }
        public double Weight { get; set; }

        
    }
}
