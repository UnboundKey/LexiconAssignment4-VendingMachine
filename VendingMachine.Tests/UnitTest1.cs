using System;
using Xunit;
using Xunit.Sdk;

namespace VendingMachine.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void InsertMoney_Valid_Denomination()
        {
            //Set up
            VendingMachine vendingMachine = new VendingMachine();

            int denomination = 10;
            int denomAmount = 5;
            
            int temp = vendingMachine.MoneyPool;
            vendingMachine.InsertMoney(denomination,denomAmount);
            Assert.Equal(denomination * denomAmount,vendingMachine.MoneyPool);
        }
        
        [Fact]
        public void InsertMoney_Invalid_Denomination()
        {
            //Set up
            VendingMachine vendingMachine = new VendingMachine();

            int denomination = 15;
            int denomAmount = 5;
            
            int temp = vendingMachine.MoneyPool;
            vendingMachine.InsertMoney(denomination,denomAmount);
            Assert.Equal(0,vendingMachine.MoneyPool);
        }
        
    }
}