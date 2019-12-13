using System.Collections.Generic;

namespace Bakery.Models
{
    public class Order
    {
        public List<Bread> BreadOrder { get; set; }
        public List<Pastry> PastryOrder { get; set; }
        Bread bread = new Bread();
        Pastry pastry = new Pastry();
        
        public Order()
        {
            BreadOrder = new List<Bread>();
            PastryOrder = new List<Pastry>();
        }

        // Amount of bread purchase is added to the BreadsOrder list
        // This can be combined with AddPastry (orderAmount and kindOfOrder)
        public void AddBread(int orederAmount)
        {
            for(int i = 0; i < orederAmount; i++)
            {
                BreadOrder.Add(bread);
            }
        }
        public void AddPastry(int orederAmount)
        {
            for(int i = 0; i < orederAmount; i++)
            {
                PastryOrder.Add(pastry);
            }
        }

        // Calculate and return total price
        public int CalcTotalPrice()
        {
            int breadTotalPrice = 0;
            int pastryTotalPrice = 0;

            // Bread calculation - first $5, second $5 and third $0
            for(int i = 0; i < BreadOrder.Count; i++)
            {
                if((i + 1) % 3 != 0)
                {
                    breadTotalPrice += BreadOrder[i].Price;
                }
            }

            // Pastry calculation - first $2, second $2 and third half price
            for(int i = 0; i < PastryOrder.Count; i++)
            {
                if((i + 1) % 3 != 0)
                {
                    pastryTotalPrice += PastryOrder[i].Price;
                }
                else
                {
                    pastryTotalPrice += PastryOrder[i].Price / 2;
                }
            }
            int totalPrice = breadTotalPrice + pastryTotalPrice;
            return totalPrice;
        }
    }
}