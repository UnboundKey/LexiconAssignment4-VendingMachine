namespace VendingMachine
{
    public abstract class Product
    {
        protected int price;
        protected string description;

        protected Product(int price, string description)
        {
            this.price = price;
            this.description = description;
        }

        public int GetPrice()
        {
            return price;
        }

        public void Examine()
        {
            System.Console.WriteLine($"Price: {price}, Description: {description}");
        }

        public void Use()
        {
            
        }
    }
}