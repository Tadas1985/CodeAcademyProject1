using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class StoreSimulation
    {   
        private readonly string LineFormatting = "{0,-20}|  {1,-10}|  {2,-10}|  {3,-15}|  {4,-15}";

        public VegetableRepository vegetableRepository { get; private set; }
        public DrinkRepository drinkRepository { get; private set; }
        public CandiesRepository candiesRepository { get; private set; }
        public MeatRepository meatRepository { get; private set; }
        public StoreSimulation()
        {           
            vegetableRepository = new VegetableRepository();
            drinkRepository = new DrinkRepository();
            candiesRepository = new CandiesRepository();
            meatRepository = new MeatRepository();
        }
        public void PrintAllVegetables()
        {
            Console.WriteLine("VEGETABLES\n");
            Console.WriteLine(String.Format(LineFormatting, vegetableRepository.Keys) + "\n");
            foreach (Vegetables vegetable in vegetableRepository.VegetableList)
            {
                Console.WriteLine(vegetable);
            }
        }
        public void PrintAllBeverages()
        {
            Console.WriteLine("BEVERAGES\n");
            Console.WriteLine(String.Format(LineFormatting, drinkRepository.Keys) + "\n");
            foreach (Drinks drink in drinkRepository.DrinksList)
            {
                Console.WriteLine(drink);
            }
        }
        public void PrintAllMeats()
        {
            Console.WriteLine("MEAT\n");
            Console.WriteLine(String.Format(LineFormatting, drinkRepository.Keys) + "\n");
            foreach (Meat meat in meatRepository.MeatList)
            {
                Console.WriteLine(meat);
            }
        }
        public void PrintAllCandy()
        {
            Console.WriteLine("CANDY\n");
            Console.WriteLine(String.Format(LineFormatting, candiesRepository.Keys) + "\n");
            foreach (Candies candy in candiesRepository.CandyList)
            {
                Console.WriteLine(candy);
            }
        }
        public void ReturnToStore()
        {
            Console.WriteLine("Press enter to return to store");
            Console.ReadKey();
        }
        public double WelcomeToStore()
        {
            Console.WriteLine("Enter how much money do you have ?");
            if (double.TryParse(Console.ReadLine(), out double result))
            {

                return result;
            }
            else
            {
                Console.WriteLine("You entered ivalid value, press enter to continue");
                Console.ReadKey();
                return 0;
 
            }
        }
        public int ValdidatorOfUserInput()
        {
            bool active = true;
            do
            {
                int answer;
                Console.WriteLine("What would you like to buy? Candies [1], Drinks [2], Meat [3], Vegetable [4],  Exit [5]");
                var rawAnswer = Console.ReadLine();
                if (int.TryParse(rawAnswer, out answer) && answer > 0 && answer < 6)
                {
                    return answer;
                    active = false;
                }
                else
                {
                    Console.WriteLine("Please enter a valid choise");
                    return 0;
                }
            } while (active);            
        }
    }   
}
