using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Basket
    {
        public string Name;
        public int Barcode;
        public int Amount;
        public decimal Price;

        public List<Basket> basketOfItems { get; set; }

        public Basket()
        {
            basketOfItems = new List<Basket>();
        }

        public Basket(string name, int barcode, int amount, decimal price)
        {
            Name = name;
            Barcode = barcode;
            Amount = amount;
            Price = price;
        }

        public void PrintAllList()
        {
            foreach (var item in basketOfItems)
            {
                Console.WriteLine(item);
            }
        }
        public void AddToCart(Vegetables product)
        {
            string name = product.Name;
            int barcode = product.BarCode;
            double amount = product.Weight;
            decimal price = product.Price;
            var productItem = new Basket(Name, Barcode, Amount, Price);
            basketOfItems.Add(productItem);
        }
        public void AddToCart(Meat product)
        {
            string name = product.Name;
            int barcode = product.BarCode;
            double amount = product.Weight;
            decimal price = product.Price;
            var productItem = new Basket(Name, Barcode, Amount, Price);
            basketOfItems.Add(productItem);
        }
        public void AddToCart(Candies product)
        {
            string name = product.Name;
            int barcode = product.BarCode;
            double amount = product.Weight;
            decimal price = product.Price;
            var productItem = new Basket(Name, Barcode, Amount, Price);
            basketOfItems.Add(productItem);
        }
        public void AddToCart(Drinks product)
        {
            string name = product.Name;
            int barcode = product.BarCode;
            int amount = product.Liters;
            decimal price = product.Price;
            var productItem = new Basket(name, barcode, amount, price);
            basketOfItems.Add(productItem);
        }

      
    }
}

