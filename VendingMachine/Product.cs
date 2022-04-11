namespace VendingMachine
{
    public abstract class Product
    {
        private int price;
        private string description;

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