using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Test
//namespace SimpleCalculator
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            //    Person person1 = new Person();
//            //    Person person2 = new Person();
//            //    person1.setAge(26);
//            //    int a=person1.getAge();
//            //    Console.WriteLine(a);
//            //    Console.WriteLine(Person.greet("apple"));
//            try
//            {
//                string input = Console.ReadLine();
//                int convertedNumber;
//                bool isconverted = int.TryParse(input, out convertedNumber);
//                if (!isconverted)
//                {
//                    throw new Exception("Couldn't be converted");
//                }
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//            finally
//            {
//                Console.WriteLine("Hey I am running anyway");
//            }
//            Console.WriteLine("Running");
        
//        }
//    }
//}
#endregion

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                InputConverter inputConverter = new InputConverter();
                CalculatorEngine calculatorEngine = new CalculatorEngine();

                double firstNum = inputConverter.Convert2Num(Console.ReadLine());
                double secondNum = inputConverter.Convert2Num(Console.ReadLine());
                string operation = Console.ReadLine();

                double result = calculatorEngine.Calculate(operation, firstNum, secondNum);
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
