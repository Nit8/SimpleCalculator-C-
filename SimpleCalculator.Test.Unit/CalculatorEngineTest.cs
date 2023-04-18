using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class CalculatorEngineTest
    {

        private readonly CalculatorEngine _calculatorEngine=new CalculatorEngine();
        [TestMethod]
        public void AddsTwoNumbersAndReturnValidResultForNonSymbolOperation()
        {
            int num1 = 1;
            int num2 = 2;
            double result1=_calculatorEngine.Calculate("add",num1 ,num2);
            Assert.AreEqual(3,result1);
            double result2 = _calculatorEngine.Calculate("multiplication", num1, num2);
            Assert.AreEqual(2, result2);
            double result3 = _calculatorEngine.Calculate("subtract", num1, num2);
            Assert.AreEqual(-1, result3);
            double result4 = _calculatorEngine.Calculate("divison", num1, num2);
            Assert.AreEqual(0.5, result4);

        }
        [TestMethod]
        public void AddsTwoNumbersAndReturnValidResultForSymbolOperation()
        {
            int num1 = 1;
            int num2 = 2;
            double result1 = _calculatorEngine.Calculate("+", num1, num2);
            Assert.AreEqual(3, result1);
            double result2 = _calculatorEngine.Calculate("-", num1, num2);
            Assert.AreEqual(-1, result2);
            double result3 = _calculatorEngine.Calculate("*", num1, num2);
            Assert.AreEqual(2, result3);
            double result4 = _calculatorEngine.Calculate("/", num1, num2);
            Assert.AreEqual(0.5, result4);

        }
    }
}
