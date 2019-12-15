namespace Bakery.Models
{
    public class Bread
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public Bread(string breadName, int price)
        {
            Name = breadName;
            Price = price;
        }

        public string PrintBread()
        {
            return this.Name;
        }
    }
}