using System;
using System.Collections.Generic;
using System.Text;

namespace Session09_Assignment
{
    public class FineCalculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int subtract(int a, int b)
        {
            return a - b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
        public int Divide(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("Can not Divide by Zero");

            return a / b;
        }
    }
}
