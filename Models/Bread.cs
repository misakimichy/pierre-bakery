namespace Bakery.Models
{
    public class Bread
    {
        public int Price { get; set; }
        public int Kind { get; set; }
        public int Quantity { get; set; }
        public string Name { get; set; }

        public Bread()
        {
            Price = 5;
            Kind = 0;
            Quantity = 0;
            Name = "";
        }
    }
}