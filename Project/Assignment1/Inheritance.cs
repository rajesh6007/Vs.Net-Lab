using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    interface IAddition    {
        double Addition(double a, double b);
    }

    interface ISubtract
    {
        double Subtract(double a, double b);
    }

    interface IMultiply
    {
        double Multiply(double a, double b);
    }

    interface IDivide
    {
        double Divide(double a, double b);
    }

    class MathOperation : IAddition, ISubtract, IMultiply, IDivide
    {
        public double Addition(double a, double b)
        {
            return a + b;
        }
        public double Subtract(double a, double b)
        {
            return a - b;
        }
        public double Multiply(double a, double b)
        {
            return a * b;
        }
        public double Divide(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Cannot divide by zero");
            return a / b;
        }
    }
}
