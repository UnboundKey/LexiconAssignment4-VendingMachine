using System;

namespace VendingMachine
{
    public interface IVending
    {
        void Purchase(Product p);
        void ShowAll();
        void InsertMoney(int currencyType, int amount);
        int[] EndTransaction();
    }
}