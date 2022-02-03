using Baseline;
using Baseline.ImTools;
using ImTools;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CandiesRepository 
    {
        
        
        public Tuple<string[], string[]> CandiesDataFromCSVFile;
        public string[] Keys;
        public List<Candies> CandyList;
        private readonly string candiesPath = @"C:\Users\tadas.valutis\Desktop\CodeAcademy\PROJECT\TextFiles\Candies.csv";

        public CandiesRepository()
        {
            var fileService = new FIleReaderService();
            CandiesDataFromCSVFile = fileService.ReadDatabase(candiesPath);
            Keys = CandiesDataFromCSVFile.Item1;
            CandyList = BuildCandyList(CandiesDataFromCSVFile.Item2);
        }

        public List<Candies> BuildCandyList(string[] inputList)
        {
            var resultList = new List<Candies>();
            foreach (string item in inputList)
            {
                var splitItem = item.Split(",");
                var CandyEntry = new Candies( splitItem[0], int.Parse(splitItem[1]), decimal.Parse(splitItem[2]),   int.Parse(splitItem[3]), double.Parse(splitItem[4]));
                resultList.Add(CandyEntry);
            }
            return resultList;
        }

        public void PrintAllProducts()
        {
            string stringAligment = "{0,-15}|  {1,-15}|  {2,-15}|  {3,-15}|  {4,-15}"; // We create a separator by | from each item
            Console.WriteLine("Candys\n");
            Console.WriteLine(String.Format( stringAligment,Keys) + "\n");
            foreach (Candies candy in CandyList)
            {
                Console.WriteLine(String.Format(stringAligment, candy.Name, candy.Sugar, candy.Price, candy.BarCode,  candy.Weight));                                                              
            }
            Console.WriteLine();
        }
    }
}
        
    
	

