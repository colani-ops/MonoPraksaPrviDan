using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    internal class Multiplication 
    {
        internal double number1;
        internal double number2;
        internal double result = 0;

        public Multiplication(double sentNumber1, double sentNumber2) 
        {
            number1 = sentNumber1;
            number2 = sentNumber2;
            result = number1 * number2;
        }
        public double GetResult()
        {
            return Math.Round(result, 2);
        }

    }
}
