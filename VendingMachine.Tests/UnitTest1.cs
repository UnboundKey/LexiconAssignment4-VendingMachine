using System;
using VendingMachine.Products;
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
            
            vendingMachine.InsertMoney(denomination,denomAmount);
            Assert.Equal(0,vendingMachine.MoneyPool);
        }

        [Fact]
        public void EndTransaction_1000()
        {
            //Set up
            VendingMachine vendingMachine = new VendingMachine();

            int denomination = 1000;
            int denomAmount = 5;
            int[] expectedReturn = new[] {0, 0, 0, 0, 0, 0, 0, 5};
            
            vendingMachine.InsertMoney(denomination,denomAmount);
            
            Assert.Equal(expectedReturn,vendingMachine.EndTransaction());
            
        }
        
        [Fact]
        public void EndTransaction_2569()
        {
            //Set up
            VendingMachine vendingMachine = new VendingMachine();

            int[] expectedReturn = new[] {4, 1, 1, 0, 1, 0, 1, 2};
            
            vendingMachine.InsertMoney(1000,2);
            vendingMachine.InsertMoney(500,1);
            vendingMachine.InsertMoney(50,1);
            vendingMachine.InsertMoney(10,1);
            vendingMachine.InsertMoney(5,1);
            vendingMachine.InsertMoney(1,4);

            
            Assert.Equal(expectedReturn,vendingMachine.EndTransaction());
            
        }

        [Fact]
        public void Purchase_EnoughMoney()
        {
            VendingMachine sut = new VendingMachine();
            
            sut.InsertMoney(500,2);
            var moneyBefore = sut.MoneyPool;
            var product = sut.Purchase("twix");

            Assert.NotNull(product);
            Assert.Equal(moneyBefore - product.GetPrice(), sut.MoneyPool);
        }
        
        [Fact]
        public void Purchase_NotEnoughMoney()
        {
            VendingMachine sut = new VendingMachine();
            
            sut.InsertMoney(1,2);
            
            var product = sut.Purchase("twix");

            Assert.Null(product);
        }

        [Fact]
        public void Examine_Product()
        {
            VendingMachine sut = new VendingMachine();
            sut.InsertMoney(1000,10);
            
            var purchase = sut.Purchase("fanta");
            Assert.NotSame(purchase.ExamineText, $"Name: {purchase.Name}, Price: {purchase.GetPrice()}, Description: {purchase.ExamineText}");
        }
        
    }
}