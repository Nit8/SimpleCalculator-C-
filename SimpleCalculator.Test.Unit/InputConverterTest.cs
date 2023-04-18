using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class InputConverterTest
    {
        private readonly InputConverter _inputConverter =new InputConverter();
        [TestMethod]
        public void ConvertValidInputIntoDouble()
        {
            string inputNum = "5";
            double convertedNum=_inputConverter.Convert2Num(inputNum);
            Assert.AreEqual(5,convertedNum);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FailsToConvertStringInputintoDouble()
        {
            string inputNum = "*";
            double convertedNum = _inputConverter.Convert2Num(inputNum);
            Assert.AreEqual(5, convertedNum);
        }

    }
}
