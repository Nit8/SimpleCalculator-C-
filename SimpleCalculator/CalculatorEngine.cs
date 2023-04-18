using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class CalculatorEngine
    {
        public double Calculate(string argOperation, double argFirstNum, double argSecondNum)
        {
            double result;
            switch(argOperation.ToLower())
            {
                case "add":
                case "+":
                    result = argFirstNum + argSecondNum;
                    break;

                case "subtract":
                case "-":
                    result = argFirstNum - argSecondNum;
                    break;

                case "multiplication":
                case "*":
                    result = argFirstNum * argSecondNum;
                    break;

                case "divison":
                case "/":
                    result = argFirstNum / argSecondNum;
                    break;

                default:
                    throw new InvalidOperationException("Specified Operation is not supported");

            }
            return result;
        }
    }
}
