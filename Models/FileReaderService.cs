using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class FIleReaderService
    {
        private readonly string pathCandies = @"C:\Users\tadas.valutis\Desktop\CodeAcademy\PROJECT\TextFiles\Candies.csv";
        private readonly string pathDrinks = @"C:\Users\tadas.valutis\Desktop\CodeAcademy\PROJECT\TextFiles\Drinks.csv";
        private readonly string pathMeat = @"C:\Users\tadas.valutis\Desktop\CodeAcademy\PROJECT\TextFiles\Meat.csv";
        private readonly string pathVegetables = @"C:\Users\tadas.valutis\Desktop\CodeAcademy\PROJECT\TextFiles\Vegetables.csv";

        public FIleReaderService()
        {
            
        }
       

        public Tuple<string[], string[]> ReadDatabase(string pathToFile)
        {
            var allLines = File.ReadAllLines(pathToFile);
            var headers = allLines[0].Split(",").ToArray();
            var entry = allLines.Skip(1).ToArray();
            var result = Tuple.Create(headers, entry);
            return result;
        }

    }
}
