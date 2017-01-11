using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sample1
{
    public class Calc
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Div(double a, double b)
        {
            return a / b;
        }

        public double DivB(double a, double b)
        {
            if (b == 0)
            {
                throw new ArgumentException("b must be non-zero!");
            }
            return a / b;
        }

        public double DivD(double a, double b)
        {
            throw new NotImplementedException();
        }
    }
}