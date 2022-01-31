using Models;
using System;
using System.Collections.Generic;

namespace Project1
{
    public class Program
    {
        

        static void Main(string[] args)
        {

               FIleReaderService fileReader = new FIleReaderService();


            CandiesRepository candyRep = new CandiesRepository();
            DrinkRepository drinksRep = new DrinkRepository();
            MeatRepository meatRep = new MeatRepository();
            VegetableRepository vegetableRep = new VegetableRepository();

            candyRep.PrintAllProducts();
            drinksRep.PrintAllProducts();
            meatRep.PrintAllProducts();

            
            
        }
    }
}
