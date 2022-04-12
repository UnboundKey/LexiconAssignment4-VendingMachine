using System;
using System.Collections.Generic;

namespace VendingMachine
{
    class Program
    {
        private static VendingMachine _vender = new VendingMachine();

        static void Main(string[] args)
        {
            _vender.InsertMoney(10, 2);
            _vender.ShowAll();
            var product = _vender.Purchase("fanta");
            product.Use();
            _vender.EndTransaction();
        }
    }
}