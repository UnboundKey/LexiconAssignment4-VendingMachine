using System;

namespace VendingMachine.Products
{
    public abstract class Product
    {
        public string Name { get; private set; }
        protected int price;
        protected string description;
        public string ExamineText;

        public Product(string name, int price, string description)
        {
            this.price = price;
            this.description = description;
            Name = name;
            ExamineText = $"Name: {this.Name}, Price: {this.price}, Description: {this.description}";
        }

        public int GetPrice()
        {
            return price;
        }

        public virtual string Examine()
        {
            Console.WriteLine(ExamineText);
            return ExamineText;
        }

        public virtual void Use()
        {
            
        }
    }
}