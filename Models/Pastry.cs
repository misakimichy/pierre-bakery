namespace Bakery.Models
{
    public class Pastry
    {
        public int Price { get; set; }
        public int Kind { get; set; }
        public int Quantity { get; set; }
        public string Name { get; set; }

        public Pastry()
        {
            Price = 2;
            Kind = 1;
            Quantity = 0;
            Name = "";
        }
    }
}