using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery
{
    class Program
    {
        public static Order userOrder = new Order();

        public static void Main()
        {
            WelcomeMessage();
            // SoliticOrder();
            int breadAmount = GetBreadMenu();
            int pastryAmount = GetPastryMenu();
            int totalPrice = userOrder.CalcTotalPrice();
            ShowTotal(breadAmount, pastryAmount, totalPrice);
        }

        public static void WelcomeMessage()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("    Welcome to the Pierre's Bakery    ");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("We have bread and pastries available today!");
            Console.WriteLine("Bread: A single loaf costs $5. Buy 2, get 1 free!");
            Console.WriteLine("Pastries: Buy 1 for $2 or 3 for $5.");
        }

        public static void SoliticOrder()
        {
            string userInput;
            Console.WriteLine("Would you like to purchase bread? (Y / N)");
            userInput = Console.ReadLine().ToUpper();
            switch(userInput)
            {
                case "Y":
                    GetBreadMenu();
                    break;
                case "N":
                    Console.WriteLine("Would you like to purchase pastries? (Y / N)");
                    userInput = Console.ReadLine().ToUpper();
                    switch(userInput)
                    {
                        case "Y":
                            GetPastryMenu();
                            break;
                        case "N":
                            Console.WriteLine("See you next time!");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Please type Y for Yes, N for No.");
                    SoliticOrder();
                    break;
            }
        }
        public static int GetBreadMenu()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("            Bread Menu");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Enter 1 for Whole-Wheat Bread: $5");
            Console.WriteLine("Enter 2 for Sourdough: $7");
            Console.WriteLine("Enter 3 for Baguette: $9");
            Console.WriteLine("Please enter the number from 1 - 3");
            int userInput = int.Parse(Console.ReadLine());
            Bread bread = null;
            switch(userInput)
            {
                case 1:
                    bread = new Bread("Whole-Wheat Bread", 5);
                    break;
                case 2:
                    bread = new Bread("Sourdough", 7);
                    break;
                case 3:
                    bread = new Bread("Baguette", 9);
                    break;
                default:
                    ErrorMessage();
                    break;
            }
            userOrder.AddBread(bread);
            return TakeBreadOrder();
        }
        public static int GetPastryMenu()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("            Pastry Menu");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Enter 1 for Croissant: $5");
            Console.WriteLine("Enter 2 for Pain au Chocolat: $7");
            Console.WriteLine("Enter 3 for Mixed Berry Danish: $9");
            Console.WriteLine("Please enter the number from 1 - 3");
            int userInput = int.Parse(Console.ReadLine());
            Pastry pastry = null;
            switch(userInput)
            {
                case 1:
                    pastry = new Pastry("Croissant", 5);
                    break;
                case 2:
                    pastry = new Pastry("Pain au Chocola", 7);
                    break;
                case 3:
                    pastry = new Pastry("Mixed Berry Danish", 9);
                    break;
                default:
                    ErrorMessage();
                    break;
            }
            userOrder.AddPastry(pastry);
            return TakePastryOrder();
        }

        public static int TakeBreadOrder()
        {
            Console.WriteLine("\nHow many loaves of bread would you like to purchase?");
            int breadAmount = 0;
            // Check if the input is a number
            bool breadInput = Int32.TryParse(Console.ReadLine(), out breadAmount);
            if(!breadInput || breadAmount < 0)
            {
                ErrorMessage();
                return TakeBreadOrder();
            }
            return breadAmount;
        }
        public static int TakePastryOrder()
        {
            Console.WriteLine("\nHow many pastries would you like to purchase?");
            int pastryAmount = 0;
            // Check if the input is a number
            bool pastryInput = Int32.TryParse(Console.ReadLine(), out pastryAmount);
            if(!pastryInput || pastryAmount < 0)
            {
                ErrorMessage();
                return TakePastryOrder();
            }
            return pastryAmount;
        }

        public static void ErrorMessage()
        {
            Console.WriteLine("Please enter a number.");
        }

        public static void ShowTotal(int breadAmount, int pastryAmount, int totalPrice)
        {
            Console.WriteLine("\n────────────────────────────────────");
            Console.WriteLine("           Pierre's Bakery");
            Console.WriteLine($"\n    Loaves of baguettes * {breadAmount}");
            Console.WriteLine($"    Croissants * {pastryAmount}");
            Console.WriteLine("------------------------------------");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"          Total: ${totalPrice}");
            Console.ResetColor();
            Console.WriteLine("\n          See you next time!");
            Console.WriteLine("────────────────────────────────────");
        }
    }
}