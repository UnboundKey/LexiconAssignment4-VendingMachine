using System;

namespace VendingMachine
{
    public abstract class Product
    {
        public string Name { get; private set; }
        protected int price;
        protected string description;
        public string ExamineText;

        protected Product(string name, int price, string description)
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

        public virtual void Examine()
        {
            Console.WriteLine(ExamineText);
        }

        public virtual void Use()
        {
            
        }
    }
}