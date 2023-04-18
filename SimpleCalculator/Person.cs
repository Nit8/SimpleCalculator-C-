using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Person
    {
        private int _age = 25;
        public int getAge()
        {
            return _age;
        }
        public void setAge(int newAge)
        {
            _age=newAge;
        }
        static public string greet(string name)
        {
            string greet = string.Format("Hello {0}", name);
            return greet;
        }
    }
}
