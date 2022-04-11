using System;

namespace VendingMachine.Products
{
    public class ProductTech : Product
    {
        private string _brand;
        private string UseText;
        private string ExamineText;
        public ProductTech(string name, int price, string description, string brand, string useText) : base(name, price, description)
        {
            _brand = brand;
            UseText = useText;
            
        }

        public override void Use()
        {
            Console.WriteLine(UseText);
        }

        public override void Examine()
        {
            ExamineText = base.ExamineText + $", Brand: {_brand}";
            Console.WriteLine(ExamineText);
        }
    }
}