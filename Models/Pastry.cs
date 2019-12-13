namespace Bakery.Models
{
    public class Pastry
    {
        public int Price { get; set; }
        public string Name { get; set; }

        public Pastry()
        {
            Price = 3;
            Name = "Croissant";
        }
    }

}