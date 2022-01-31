using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class DrinkRepository: Drinks
    {
        private readonly string pathDrinks = @"C:\Users\tadas.valutis\Desktop\CodeAcademy\PROJECT\TextFiles\Drinks.csv";
        public List<Drinks> drinkList = new List<Drinks>();

        public DrinkRepository(string name, int liters, decimal price, int barCode, double weight) : base(name, liters, price, barCode, weight)
        {
        }

        public void ReadCSVFile()
        {
            var lines = File.ReadAllLines(pathDrinks);
            foreach (var line in lines)
            {
                string[] rawData = line.Split(',');
                var drinks = new Drinks(Name, Liters, Price, BarCode, Weight) { Name = rawData[0], Liters = Convert.ToInt32(rawData[1]), Price = Convert.ToDecimal(rawData[2]), BarCode = Convert.ToInt32(rawData[3]), Weight = Convert.ToDouble(rawData[4]) };
                drinkList.Add(drinks);
            }
            
        }
    }
}
