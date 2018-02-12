using FitnessTest.Interfaces;
using FitnessTest.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTest.Tests
{
    [TestClass]
    public class TestOrders
    {
        ObservableCollection<Order> testOrders;
        IOrderStore orderStore;
        IOrderWriter orderWriter;

        [TestInitialize]
        public void TestInit()
        {
            testOrders = new ObservableCollection<Order>()
            {
                new Order() { Price = 1, Size = 10, Symbol = "A" },
                new Order() { Price = 2, Size = 9, Symbol = "B" },
                new Order() { Price = 3, Size = 8, Symbol = "C" },
                new Order() { Price = 4, Size = 7, Symbol = "D" },
                new Order() { Price = 5, Size = 6, Symbol = "E" },
                new Order() { Price = 6, Size = 5, Symbol = "F" },
                new Order() { Price = 7, Size = 4, Symbol = "G" },
                new Order() { Price = 8, Size = 3, Symbol = "H" },
                new Order() { Price = 9, Size = 2, Symbol = "I" },
                new Order() { Price = 10, Size = 1, Symbol = "L" },
            };
        }

        [TestMethod]
        public void NumberExtensions_ConvertReturns0()
        {
            SmallOrderManager som = new SmallOrderManager()
        }
    }
}
