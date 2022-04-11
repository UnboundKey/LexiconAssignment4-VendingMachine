using System;
using System.Collections.Generic;
using VendingMachine.Products;

namespace VendingMachine
{
    class Program
    {
        private static VendingMachine vender;
        static void Main(string[] args)
        {
            vender.InsertMoney(50,2);
        }
    }
}