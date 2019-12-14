namespace Bakery.Models
{
    public class Bread
    {
        public int Price { get; set; }
        public string Name { get; set; }

        public Bread()
        {
            Price = 5;
            Name = "";
        }
    }
}