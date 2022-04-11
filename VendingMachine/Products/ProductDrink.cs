namespace VendingMachine.Products
{
    public class ProductDrink : Product
    {
        private double volume;

        public ProductDrink(int price, string description, double volume) : base(price, description)
        {
            this.volume = volume;
        }

        public new void Examine()
        {
            System.Console.WriteLine($"Price: {price}, Description: {description}, Litres: {volume}");
        }
    }
}