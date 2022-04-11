﻿using System;

namespace VendingMachine.Products
{
    public class ProductDrink : Product
    {
        private double _volume;
        private string UseText;
        private string ExamineText;
        public ProductDrink(string name, int price, string description, double volume, string useText) : base(name, price, description)
        {
            _volume = volume;
            UseText = useText;
            
        }

        public override void Use()
        {
            Console.WriteLine(UseText);
        }

        public override void Examine()
        {
            ExamineText = base.ExamineText + $", CL {_volume}";
            Console.WriteLine(ExamineText);
        }
    }
}