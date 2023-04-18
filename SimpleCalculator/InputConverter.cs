using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class InputConverter
    {
        public double Convert2Num(string argInput)
        {
            double convertedNum;
            if (!double.TryParse(argInput, out convertedNum)) throw new ArgumentException("Input could not be processed");
            return convertedNum;
        }
    }
}
