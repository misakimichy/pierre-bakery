using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery
{
    class Program
    {
        public static void Main()
        {
            Order order = new Order();
            WelcomeMessage();
            int breadAmount = TakeBreadOrder();
            int pastryAmount = TakePastryOrder();
            order.AddBread(breadAmount);
            order.AddPastry(pastryAmount);
            int totalPrice = order.CalcTotalPrice();
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
            Console.WriteLine("Do you like to purchase bread? (Y for Yes, N for No)");
            string userInput = Console.ReadLine().ToUpper();
            switch(userInput)
            {
                case "Y":
                    GetBreadKind();
                    break;
                case "N":
                    Console.WriteLine("Do you like to purchase pastries (Y for Yes, N for No");
                    GetPastryKind();
                    break;
                default:
                    Console.WriteLine("Please type Y for Yes, N for No.");
                    SoliticOrder();
                    break;
            }
        }
        public static void GetBreadKind()
        {
            Console.WriteLine("\nWhat kind of bread do you want to purchase?");
            Console.WriteLine("1: Baguette, 2: Sourdough, 3: Whole Grain Bread");
            int breadKind = 0;
            bool userInput = Int32.TryParse(Console.ReadLine(), out breadKind);
            if(!userInput || breadKind < 0)
            {
                ErrorMessage();
                GetBreadKind();
            }
            switch(breadKind)
            {
                case 1:
                    userOrder.AddItem("Baguette", 1);
                    break;
                case 2:
                    userOrder.AddItem("Sourdough", 1);
                    break;
                case 3:
                    userOrder.AddItem("Whole Grain Bread", 1);
                    break;
            }
        }
        public static void GetPastryKind()
        {
            Console.WriteLine("\nWhat kind of pastries do you want to purchase?");
            Console.WriteLine("1: Croissant, 2: Eclair, 3: Moon Cake");
            int pastryKind = 0;
            bool userInput = Int32.TryParse(Console.ReadLine(), out pastryKind);
            if(!userInput || pastryKind < 0)
            {
                ErrorMessage();
                GetPastryKind();
            }
            switch(pastryKind)
            {
                case 1:
                    userOrder.AddItem("Croissant", 2);
                    break;
                case 2:
                    userOrder.AddItem("Eclair", 2);
                    break;
                case 3:
                    userOrder.AddItem("Moon Cake", 2);
                    break;
            }
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
            int breadPrice = 100;
            return breadPrice;
        }
        public static int TakePastryOrder()
        {
            Console.WriteLine("\nHow many pastries would you like to purchase?");
            int pastryAmount = 0;
            // Check if the input is a number
            bool pastryInput = Int32.TryParse(Console.ReadLine(), out pastryAmount);
            if(!pastryInput || pastryAmount < 0)
            {
                Console.WriteLine("Please enter a number");
                return TakePastryOrder();
            }
            return pastryAmount;
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