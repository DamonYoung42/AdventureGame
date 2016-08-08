using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName;
            string favoriteColor;
            List<string> shoppingList = new List<string> {};
            int numItems = 0;

            Console.WriteLine("Welcome to the land of the unknown. This is a simple interactive story. What is your name?");
            userName = Console.ReadLine();
            Console.WriteLine("Hello, " + userName);
            Console.WriteLine("What is your favorite color?");
            favoriteColor = Console.ReadLine();
            switch (favoriteColor.ToUpper())
            {
                case "BLUE":
                    Console.WriteLine("Awesome! That's my favorite color, too");
                    break;
                case "GREEN":
                    Console.WriteLine("Ewww! I don't like that.");
                    break;
                case "RED":
                    Console.WriteLine("OK. You may be a vampire!");
                    break;
                default:
                    Console.WriteLine("You must not have had any friends as a child!");
                    break;        
            }

            Console.WriteLine("We're going to go to the grocery store this afternoon. How many items would you like to buy?");
            numItems = Convert.ToInt16(Console.ReadLine());

            for (int i = 0; i < numItems; i++)
            {
                Console.WriteLine("Enter an item you need to buy:");
                shoppingList.Insert(i, Console.ReadLine());
            }

            Console.WriteLine("Before we go to the store, let's check out that list!");

            foreach (string item in shoppingList)
            {
                switch (item.ToUpper())
                {
                    case "SODA":
                        Console.WriteLine("Soda is not very healthy; there are plenty of suitable alternatives.");
                        break;
                    case "CHIPS":
                    case "POTATO CHIPS":
                        Console.WriteLine("Maybe try some fruit instead of those potato chips!");
                        break;
                    case "BEER":
                    case "WINE":
                        Console.WriteLine("I also enjoy an adult beverage or two!");
                        break;
                    case "FRUIT":
                        Console.WriteLine("Fruit is great!");
                        break;
                    default:
                        Console.WriteLine("I've never bought " + item);
                        break;
                }
            }

            Console.WriteLine("Thanks for letting me go to the store with you. Have a great day!");
        }
    }
}
