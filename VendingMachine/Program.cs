using System;
using System.Collections.Generic;

namespace VendingMachine
{
    class Program
    {
        private static VendingMachine vm = new VendingMachine();
        
        static void Main(string[] args)
        {
            vm.InsertMoney(50,2);
            
            Console.WriteLine("Hello World!");
        }
    }
}