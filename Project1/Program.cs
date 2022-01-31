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

            DrinkRepository drinksRep = new DrinkRepository("Name", 1, 1, 111, 3);
            CandiesRepository candyRep = new CandiesRepository("Name",2,3,4,5);
            MeatRepository meatRep = new MeatRepository("Name", 2, 3, 4, 3);
            VegetableRepository vegetableRep = new VegetableRepository("Name",1,2,3,4);
            candyRep.ReadCSVFile();
            foreach (var item in candyRep.candiesList)
            {
                Console.WriteLine(item.Name);

            }
            

            drinksRep.ReadCSVFile();
            foreach (var item in drinksRep.drinkList)
            {
                Console.WriteLine(item.Name);

            }
           


            meatRep.ReadCSVFile();
            foreach (var item in meatRep.meatList)
            {
                Console.WriteLine(item.Name);

            }
           

            vegetableRep.ReadCSVFile();
            foreach (var item in vegetableRep.vegetableList)
            {
                Console.WriteLine(item.Name);

            }

            Console.WriteLine("Enter how much m money you have?");
            decimal amountOfMoney = decimal.Parse(Console.ReadLine());

        }
    }
}
