using Models;
using System;
using System.Collections.Generic;

namespace Project1
{
    public class Program:StoreSimulation
    {
        

        static void Main(string[] args)
        {
           
            
            FIleReaderService fileReader = new FIleReaderService();


            CandiesRepository candyRep = new CandiesRepository();
            DrinkRepository drinksRep = new DrinkRepository();
            MeatRepository meatRep = new MeatRepository();
            VegetableRepository vegetableRep = new VegetableRepository();
            Basket basket = new Basket();
            double amountOfMoney;
            bool isActive;
            int choise;

           
            StoreSimulation store = new StoreSimulation();
           
            bool isAlive = true;
            while (isAlive)
            {
                amountOfMoney = store.WelcomeToStore();
                if (amountOfMoney == 0)
                {
                    // If user have 0 money we show only what is available in shop

                    Console.WriteLine("you can only see items \n \n");
                    candyRep.PrintAllProducts();
                    drinksRep.PrintAllProducts();
                    meatRep.PrintAllProducts();
                    vegetableRep.PrintAllProducts();
                }
                else // If user have >0 money we show what is available in shop and ask to choose a category
                {
                    candyRep.PrintAllProducts();
                    drinksRep.PrintAllProducts();
                    meatRep.PrintAllProducts();
                    vegetableRep.PrintAllProducts();
                    Console.WriteLine("What would you like to buy? Candies [1], Drinks [2], Meat [3], Vegetable [4],  Exit [5]");
                    var inputChoise = Convert.ToInt32(Console.ReadLine());
                    if (inputChoise >= 1 && inputChoise <= 5) //Int32.TryParse(Console.ReadLine(), out int inputChoise))
                    {
                        switch (inputChoise) // When user chose a category we as what tipe of item he would like to buy and place that item into a shoping cart list
                        {
                            case 1:
                                
                               
                                Console.WriteLine("What tipe of candies would you like to buy?: Caramel [1], Sugar Candy [2], Chocolate [3], Dark Chocolate [4], Milk Chocolate");
                                candyRep.PrintAllProducts();
                                int candyChoice = Convert.ToInt32(Console.ReadLine());
                                if (candyChoice == 1)
                                {
                                    basket.AddToCart(candyRep.CandyList[0]);
                                    foreach (var item in basket.basketOfItems)
                                    {
                                        Console.WriteLine(item.Name);
                                    }
                                }
                                else if (candyChoice == 2)
                                {
                                    basket.AddToCart(candyRep.CandyList[1]);
                                }
                                else if (candyChoice == 3)
                                {
                                    basket.AddToCart(candyRep.CandyList[2]);
                                }
                                else { basket.AddToCart(candyRep.CandyList[3]); }

                                break;
                            case 2:
                                
                                Console.WriteLine("What tipe of drinks would you like to buy?: Red Wine [1], White Wine [2], Beer [3], Juce [4], Tea");
                                drinksRep.PrintAllProducts();
                                int drinkChoice = Convert.ToInt32(Console.ReadLine());
                                //store.ReturnToStore();
                                if (drinkChoice ==1)
                                {
                                    basket.AddToCart(drinksRep.DrinksList[0]);
                                }
                                else if (drinkChoice ==2)
                                {
                                    basket.AddToCart(drinksRep.DrinksList[1]);
                                }
                                else if (drinkChoice==3)
                                {
                                    basket.AddToCart(drinksRep.DrinksList[3]);
                                }
                                else
                                {
                                    basket.AddToCart(drinksRep.DrinksList[4]);
                                }
                                break;
                            case 3:
                                
                                Console.WriteLine("What tipe of meat would you like to buy?: Beef [1], Deer [2], Chicken [3], Fish [4], Pork");
                                meatRep.PrintAllProducts();
                                int meatChoice = Convert.ToInt32(Console.ReadLine());
                                //store.ReturnToStore();
                                if (meatChoice == 1)
                                {
                                    basket.AddToCart(meatRep.MeatList[0]);
                                }
                                else if (meatChoice ==2)
                                {
                                    basket.AddToCart(meatRep.MeatList[1]);
                                }
                                else if (meatChoice==3)
                                {
                                    basket.AddToCart(meatRep.MeatList[2]);
                                }
                                else if (meatChoice==3)
                                {
                                    basket.AddToCart(meatRep.MeatList[3]);
                                }
                                else
                                {
                                    basket.AddToCart(meatRep.MeatList[4]);
                                }
                                break;
                            case 4:
                                
                                Console.WriteLine("What tipe of vegetables would you like to buy?: Cabbage [1], Carrots [2], Tomatoe [3], Onions [4], Cucumber");

                                int vegetableChoice = Convert.ToInt32(Console.ReadLine());
                                //store.ReturnToStore();
                                if (vegetableChoice ==1)
                                {
                                    basket.AddToCart(vegetableRep.VegetableList[0]);
                                }
                                else if (vegetableChoice == 2)
                                {
                                    basket.AddToCart(vegetableRep.VegetableList[1]);
                                }
                                else if (vegetableChoice ==3)
                                {
                                    basket.AddToCart(vegetableRep.VegetableList[2]);
                                }
                                else if (vegetableChoice ==4)
                                {
                                    basket.AddToCart(vegetableRep.VegetableList[3]);
                                }
                                else
                                {
                                    basket.AddToCart(vegetableRep.VegetableList[4]);
                                }
                                break;
                            case 5:
                                isAlive = false;
                                break;
                            default:
                                Console.WriteLine("No such command, press enter to continue");
                                Console.ReadKey();
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("You entered not the number, press enter to continue");
                        Console.ReadKey();
                    }
                }


            }
            


        }
    }
}
