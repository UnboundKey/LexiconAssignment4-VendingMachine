using System;
using System.Collections.Generic;
using VendingMachine.Products;

namespace VendingMachine
{
    public class VendingMachine : IVending
    {
        private readonly int[] _acceptedDenominations = { 1,5,10,20,50,100,500,1000};
        public int MoneyPool { get; private set; }

        private List<Product> _availableProducts = new List<Product>()
        {
            new ProductCandy("Twix",12,"Twix Bar",50,"You eat one of the two twix bars"),
            
            new ProductTech("IPhone",1500,"This is the latest product from the apple","Apple","You called your mom"),
            
            new ProductDrink("Fanta", 15,"A sweet soft drink with an artificial orange flavour, from the coke company",33, "You Drunk the Fanta"),
        };

        public Product Purchase(string productname)
        {
            foreach (Product product in _availableProducts)
            {
                // Check if a product of a specific name exists and can be purchased.
                if (productname.ToLower() == product.Name.ToLower() && MoneyPool >= product.GetPrice())
                {
                    MoneyPool -= product.GetPrice();
                    return product;
                }
            }
            Console.WriteLine("Product could not be purchased, this might be because you might not have enough money or the product isn't available");
            return null;
        }

        public void ShowAll()
        {
            foreach (var product in _availableProducts)
            {
                product.Examine();
            }
        }

        public void InsertMoney(int currencyType, int amount)
        {
            foreach (var denomination in _acceptedDenominations)
            {
                if (currencyType == denomination)
                {
                    MoneyPool += currencyType * amount;
                }
            }
        }

        public int[] EndTransaction()
        {
            int[] returnDenomAmount = new int[_acceptedDenominations.Length];
            //Check against largest denom first
            for (int i = _acceptedDenominations.Length - 1; i >= 0; i--)
            {
                // Check if there are any of a specific denomination
                if ((MoneyPool / _acceptedDenominations[i]) >= 0)
                {
                    // Get amount of a specific denomination in the MoneyPool and round down to a whole number
                    var denomAmount = Math.Floor((double) (MoneyPool / _acceptedDenominations[i]));
                    // Store the denomination amount for later
                    returnDenomAmount[i] = (int) denomAmount;
                    // Remove the money counted from the MoneyPool
                    MoneyPool -= (int)(denomAmount * _acceptedDenominations[i]);
                }

            }

            Console.WriteLine($"1s: {returnDenomAmount[0]}, " +
                              $" 5s: {returnDenomAmount[1]}, " +
                              $" 10s: {returnDenomAmount[2]}, " +
                              $" 20s: {returnDenomAmount[3]}, " +
                              $" 50s: {returnDenomAmount[4]}, " +
                              $" 100s: {returnDenomAmount[5]}, " +
                              $" 500s: {returnDenomAmount[6]}, " +
                              $" 1000s: {returnDenomAmount[7]}, ");
            return returnDenomAmount;
        }
    }
}