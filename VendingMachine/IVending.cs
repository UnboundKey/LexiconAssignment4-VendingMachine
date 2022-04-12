using System;
using VendingMachine.Products;

namespace VendingMachine
{
    public interface IVending
    {
        Product Purchase(string productname);
        string ShowAll();
        void InsertMoney(int currencyType, int amount);
        int[] EndTransaction();
    }
}