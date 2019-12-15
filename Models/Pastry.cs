namespace Bakery.Models
{
    public class Pastry
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public Pastry(string pastryName, int price)
        {
            Name = pastryName;
            Price = price;
        }
        public string PrintPastry()
        {
            return this.Name;
        }
    }
}