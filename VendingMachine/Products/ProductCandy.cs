using System;

namespace VendingMachine.Products
{
    public class ProductCandy : Product
    {
        private double _weight;
        private string UseText;
        private new string ExamineText;

        public ProductCandy(string name, int price, string description, double weight, string useText) : base(name,
            price, description)
        {
            _weight = weight;
            UseText = useText;
        }

        public override void Use()
        {
            Console.WriteLine(UseText);
        }

        public override string Examine()
        {
            ExamineText = base.ExamineText + $", Weight {_weight}";
            Console.WriteLine(ExamineText);
            return ExamineText;
        }
    }
}