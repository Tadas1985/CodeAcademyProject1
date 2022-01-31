using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class VegetableRepository: Vegetables
    {
        private readonly string pathVegetables = @"C:\Users\tadas.valutis\Desktop\CodeAcademy\PROJECT\TextFiles\Vegetables.csv";
        public List<Vegetables>vegetableList = new List<Vegetables>();

        public VegetableRepository(string name, int fiber, decimal price, int barCode, double weight) : base(name, fiber, price, barCode, weight)
        {
        }

        public void ReadCSVFile()
        {
            var lines = File.ReadAllLines(pathVegetables);
            foreach (var line in lines)
            {
                string[] rawData = line.Split(',');
                var vegetables = new Vegetables(Name, Fiber, Price, BarCode, Weight) { Name = rawData[0], Fiber = Convert.ToInt32(rawData[1]), Price = Convert.ToDecimal(rawData[2]), BarCode = Convert.ToInt32(rawData[3]), Weight = Convert.ToDouble(rawData[4]) };
                vegetableList.Add(vegetables);
            }
            vegetableList.ForEach(meats => Console.WriteLine(meats));
        }
       
    }
}
