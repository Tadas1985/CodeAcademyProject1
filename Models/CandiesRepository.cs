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
    public class CandiesRepository : Candies
    {
        public List<Candies> candiesList = new List<Candies>();

        private string pathCandies = @"C:\Users\tadas.valutis\Desktop\CodeAcademy\PROJECT\TextFiles\Candies.csv";
        public string[] csvLines = File.ReadAllLines(@"C:\Users\tadas.valutis\Desktop\CodeAcademy\PROJECT\TextFiles\Candies.csv");

        
        

        public CandiesRepository(string name, int sugar, decimal price, int barCode, double weight) : base(name, sugar, price, barCode, weight)
        {
            Name = name;
            Sugar = sugar;
            Price = price;
            Weight = weight;



        }

        public void ReadCSVFile()
        {
            var lines = File.ReadAllLines(pathCandies);
            foreach (var line in lines)
            {
                string[] rawData = line.Split(',');
                var candy = new Candies(Name, Sugar, Price,BarCode,Weight) { Name = rawData[0], Sugar = Convert.ToInt32(rawData[1]), Price = Convert.ToDecimal(rawData[2]), BarCode = Convert.ToInt32(rawData[3]), Weight = Convert.ToDouble(rawData[4]) };
                candiesList.Add(candy);
            }  
            
        }

       
    }
    
}
        
    
	

