using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class VegetableRepository
    {
        public Tuple<string[], string[]> VegetableDataFromCSVFile;
        public string[] Keys;
        public List<Vegetables> VegetableList;
        private readonly string VegetablePath = @"C:\Users\tadas.valutis\Desktop\CodeAcademy\PROJECT\TextFiles\Vegetables.csv";

        public VegetableRepository()
        {
            var fileService = new FIleReaderService();
            VegetableDataFromCSVFile = fileService.ReadDatabase(VegetablePath);
            Keys = VegetableDataFromCSVFile.Item1;
            VegetableList = BuildVegetablesList(VegetableDataFromCSVFile.Item2);
        }

        public List<Vegetables> BuildVegetablesList(string[] inputList)
        {
            var resultList = new List<Vegetables>();
            foreach (string item in inputList)
            {
                var splitItem = item.Split(",");
                var VegetableEntry = new Vegetables(splitItem[0], Convert.ToInt32(splitItem[1]), Convert.ToDecimal(splitItem[2]), Convert.ToInt32(splitItem[3]), Convert.ToDouble(splitItem[4]));
                resultList.Add(VegetableEntry);
            }
            return resultList;
        }

        public void PrintAllProducts()
        {
            string stringAligment = "{0,-15}|  {1,-10}|  {2,-10}|  {3,-15}|  {4,-15}";
            Console.WriteLine("Drinks\n");
            Console.WriteLine(String.Format(stringAligment, Keys) + "\n");
            foreach (Vegetables vegetables in VegetableList)
            {
                Console.WriteLine(String.Format(stringAligment, vegetables.Name, vegetables.Fiber, vegetables.Price, vegetables.BarCode, vegetables.Weight));


            }
            Console.WriteLine();
        }

    }
}
