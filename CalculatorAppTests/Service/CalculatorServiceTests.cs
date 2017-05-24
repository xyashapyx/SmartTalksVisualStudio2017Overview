using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorApp.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp.Service.Tests
{
    [TestClass()]
    public class CalculatorServiceTests
    {
        [TestMethod()]
        public void SumTest()
        {
            //Arrange 
            var num1 = 2.2;
            var num2 = 4.1;
            //Assert 
            Assert.AreEqual(CalculatorService.Sum(num1, num2), num1 + num2);
        }

        [TestMethod()]
        public void PowTest()
        {
            //Arrange 
            var num1 = 2.2;
            var num2 = 4.1;
            //Assert 
            Assert.AreEqual(CalculatorService.Pow(num1, num2), Math.Pow(num2, num1));
        }
    }
}