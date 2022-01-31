using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class MeatRepository: Meat
    {
        private readonly string pathMeat = @"C:\Users\tadas.valutis\Desktop\CodeAcademy\PROJECT\TextFiles\Meat.csv";
        public List <Meat>meatList = new List<Meat>();
        public MeatRepository(string name, int protein, decimal price, int barCode, double weight) : base(name, protein, price, barCode, weight)
        {

            
        }
        public void ReadCSVFile()
        {
            var lines = File.ReadAllLines(pathMeat);
            foreach (var line in lines)
            {
                string[] rawData = line.Split(',');
                var meats = new Meat(Name, Protein, Price, BarCode, Weight) { Name = rawData[0], Protein = Convert.ToInt32(rawData[1]), Price = Convert.ToDecimal(rawData[2]), BarCode = Convert.ToInt32(rawData[3]), Weight = Convert.ToDouble(rawData[4]) };
                meatList.Add(meats);
            }
            
        }
    }
}
