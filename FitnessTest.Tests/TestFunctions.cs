using FitnessTest.Extensions;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FitnessTest.Tests
{
    [TestClass]
    public class TestFunctions
    {
        [TestMethod]
        public void NumberExtensions_ConvertANumber()
        {
            string numberToConvert = "10";
            int result = numberToConvert.ToNumber();

            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void NumberExtensions_ConvertReturns0()
        {
            string numberToConvert = "A10";
            int result = numberToConvert.ToNumber();

            Assert.AreEqual(0, result);
        }
    }
}
