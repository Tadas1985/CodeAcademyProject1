using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class DrinkRepository
    {
        
        public Tuple<string[], string[]> DrinksDataFromCSVFile;
        public string[] Keys;
        public List<Drinks> DrinksList;
        private readonly string DrinksPath = @"C:\Users\tadas.valutis\Desktop\CodeAcademy\PROJECT\TextFiles\Drinks.csv";

        public DrinkRepository()
        {
            var fileService = new FIleReaderService();
            DrinksDataFromCSVFile = fileService.ReadDatabase(DrinksPath);
            Keys = DrinksDataFromCSVFile.Item1;
            DrinksList = BuildDrinksList(DrinksDataFromCSVFile.Item2);
        }

        public List<Drinks> BuildDrinksList(string[] inputList)
        {
            var resultList = new List<Drinks>();
            foreach (string item in inputList)
            {
                var splitItem = item.Split(",");
                var DrinksEntry = new Drinks(splitItem[0], int.Parse(splitItem[1]), decimal.Parse(splitItem[2]), int.Parse(splitItem[3]), int.Parse(splitItem[4]));
                resultList.Add(DrinksEntry);
            }
            return resultList;
        }

        public void PrintAllProducts()
        {
            string stringAligment = "{0,-15}|  {1,-15}|  {2,-15}|  {3,-15}|  {4,-15}";
            Console.WriteLine("Drinks\n");
            Console.WriteLine(String.Format(stringAligment, Keys) + "\n");
            foreach (Drinks drink in DrinksList)
            {
                Console.WriteLine(String.Format(stringAligment, drink.Name, drink.Liters, drink.Price, drink.BarCode, drink.Weight));


            }
            Console.WriteLine();
        }
    }
}
