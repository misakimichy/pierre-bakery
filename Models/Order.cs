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
        public void AddBread(Bread bread)
        {
            BreadOrder.Add(bread);
        }

        public void AddPastry(Pastry pastry)
        {
            PastryOrder.Add(pastry);
        }

        public string GetBread()
        {
            string kinds = "";
            for(int i = 0; i < BreadOrder.Count; i++)
            {
                kinds += BreadOrder[i].PrintBread();
            }
            return kinds;
        }

        public string GetPastry()
        {
            string kinds = "";
            for(int i = 0; i < PastryOrder.Count; i++)
            {
                kinds += PastryOrder[i].PrintPastry();
            }
            return kinds;
        }

        // Calculate and return total price
        public int CalcTotalPrice()
        {
            int breadTotal = 0;
            int pastryTotal = 0;
            // Bread price calculation - Buy 2, get 1 free
            for(int i = 0; i < BreadOrder.Count; i++)
            {
                if((i + 1) % 3 != 0)
                {
                    breadTotal += BreadOrder[i].Price;
                }
            }
            // Pastry price calculation - Buy 1 for proper price or 3 for proper * 2 + proper/2.
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