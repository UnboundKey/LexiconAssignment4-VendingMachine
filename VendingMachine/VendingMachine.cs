using System;
using System.Collections.Generic;

namespace VendingMachine
{
    public class VendingMachine : IVending
    {
        private readonly int[] _acceptedDenominations = { 1,5,10,20,50,100,500,1000};
        public int MoneyPool { get; private set; }

        private static List<Product> availableProducts = new List<Product>(){};

        public void Purchase(Product p)
        {
            
        }

        public void ShowAll()
        {
            foreach (var product in availableProducts)
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
                // If 
                if ((MoneyPool / _acceptedDenominations[i]) >= 0)
                {
                    var denomAmount = Math.Floor((double) (MoneyPool / _acceptedDenominations[i]));
                    
                    returnDenomAmount[i] = (int) denomAmount;
                    MoneyPool -= (int)(denomAmount * _acceptedDenominations[i]);
                }

            }
            return returnDenomAmount;
        }
    }
}