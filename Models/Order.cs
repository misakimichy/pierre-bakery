using System.Collections.Generic;

namespace Bakery.Models
{
    public class Order
    {
        public static List<Bread> BreadOrder { get; set; }
        public static List<Pastry> PastryOrder { get; set; }
        
        public Order()
        {
            BreadOrder = new List<Bread>();
            PastryOrder = new List<Pastry>();
        }

        // Amount of bread purchase is added to the BreadsOrder list
        public void CountQuantity(int orederAmount, int kind)
        {
            for(int i = 1; i <= orederAmount; i++)
            {
                switch(kind)
                {
                    case 1:
                        BreadOrder[i].Quantity++;
                        break;
                    case 2:
                        PastryOrder[i].Quantity++;
                        break;
                }
            }
            // return breadQuantity;
        }

        public void AddItem(string item, int kind)
        {
            for(int i = 0; i < BreadOrder.Count; i++)
            {
                switch(kind)
                {
                    case 1:
                        BreadOrder[i].Name = item;
                        break;
                    case 2:
                        PastryOrder[i].Name = item;
                        break;
                }
            }
        }

        // Calculate and return total price
        public int CalcTotalPrice()
        {
            int breadTotal = 0;
            int pastryTotal = 0;
            // Bread calculation - first $5, second $5 and third $0
            for(int i = 0; i < BreadOrder.Count; i++)
            {
                if((i + 1) % 3 != 0)
                {
                    breadTotal += BreadOrder[i].Price;
                }
            }

            // Pastry calculation - first $2, second $2 and third half price
            for(int i = 0; i < PastryOrder.Count; i++)
            {
                if((i + 1) % 3 != 0)
                {
                    pastryTotal += PastryOrder[i].Price;
                }
                else
                {
                    pastryTotal += PastryOrder[i].Price / 2;
                }
            }
            return (breadTotal + pastryTotal);
        }
    }
}