using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class MeatRepository
    {
        

        public Tuple<string[], string[]> MeatDataFromCSVFile;
        public string[] Keys;
        public List<Meat> MeatList;
        private readonly string MeatPath = @"C:\Users\tadas.valutis\Desktop\CodeAcademy\PROJECT\TextFiles\Meat.csv";

        public MeatRepository()
        {
            var fileService = new FIleReaderService();
            MeatDataFromCSVFile = fileService.ReadDatabase(MeatPath);
            Keys = MeatDataFromCSVFile.Item1;
            MeatList = BuildMeatList(MeatDataFromCSVFile.Item2);
        }

        public List<Meat> BuildMeatList(string[] inputList)
        {
            var resultList = new List<Meat>();
            foreach (string item in inputList)
            {
                var splitItem = item.Split(",");
                var MeatEntry = new Meat(splitItem[0], int.Parse(splitItem[1]), decimal.Parse(splitItem[2]), int.Parse(splitItem[3]), double.Parse(splitItem[4]));
                resultList.Add(MeatEntry);
            }
            return resultList;
        }

        public void PrintAllProducts()
        {
            string stringAligment = "{0,-15}|  {1,-15}|  {2,-15}|  {3,-15}|  {4,-15}";
            Console.WriteLine("Drinks\n");
            Console.WriteLine(String.Format(stringAligment, Keys) + "\n");
            foreach (Meat meat in MeatList)
            {
                Console.WriteLine(String.Format(stringAligment, meat.Name, meat.Protein, meat.Price, meat.BarCode, meat.Weight));

            }
            Console.WriteLine();
        }
    }
}
