using System;

namespace VendingMachine.Products
{
    public class ProductDrink : Product
    {
        private double _volume;
        private string UseText;
        private new string ExamineText;
        public ProductDrink(string name, int price, string description, double volume, string useText) : base(name, price, description)
        {
            _volume = volume;
            UseText = useText;
            
        }

        public override void Use()
        {
            Console.WriteLine(UseText);
        }

        public override string Examine()
        {
            ExamineText = base.ExamineText + $", CL {_volume}";
            Console.WriteLine(ExamineText);
            return ExamineText;
        }
    }
}