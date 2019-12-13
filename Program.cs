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

        public static int TakeBreadOrder()
        {
            Console.WriteLine("\nHow many loaves of bread would you like to purchase?");
            int breadAmount = 0;
            // Check if the input is a number
            bool breadInput = Int32.TryParse(Console.ReadLine(), out breadAmount);
            if(!breadInput)
            {
                Console.WriteLine("Please enter a number");
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
            if(!pastryInput)
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