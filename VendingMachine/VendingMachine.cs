using System.Collections.Generic;

namespace VendingMachine
{
    public class VendingMachine : IVending
    {
        private static int[] acceptedDenominations = { 1,5,10,20,50,100,500,1000};
        public int MoneyPool { get; private set; }

        private List<Product> availableProducts = new List<Product>(){};

        public void Purchase(Product p)
        {
            
        }

        public void ShowAll()
        {
            throw new System.NotImplementedException();
        }

        public void InsertMoney(int currencyType, int amount)
        {
            foreach (var denomination in acceptedDenominations)
            {
                if (currencyType == denomination)
                {
                    MoneyPool += currencyType * amount;
                }
            }
        }

        public void EndTransaction()
        {
            
        }
    }
}