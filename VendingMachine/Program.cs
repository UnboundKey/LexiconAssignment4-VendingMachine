using System;
using System.Collections.Generic;

namespace VendingMachine
{
    class Program
    {
        private static VendingMachine _vender = new VendingMachine();
        static void Main(string[] args)
        {
            _vender.InsertMoney(10,3);
            _vender.Purchase("fanta");
            _vender.EndTransaction();
        }
    }
}