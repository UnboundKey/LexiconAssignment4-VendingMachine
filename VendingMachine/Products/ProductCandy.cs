using System;

namespace VendingMachine.Products
{
    public class ProductCandy : Product
    {
        private double _weight;
        private string UseText;
        public ProductCandy(int price, string description, double weight, string useText) : base(price, description)
        {
            this._weight = weight;
            UseText = useText;
        }
        
        public new void Examine()
        {
            System.Console.WriteLine($"Price: {price}, Description: {description}, Kilogrammes: {_weight}");
        }

        public new string Use()
        {
            return UseText;
        }
    }
}