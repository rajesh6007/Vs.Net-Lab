using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Overloading
    {
        //Method to add two integers
        public int Add(int a, int b)
            {
            return a + b;
            }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

    }


    interface IAddition
        {
            double Add(double a, double b);
        }
    interface ISubtraction
        {
            double Sub(double a, double b);
        }
    interface IMultiplication
        {
            double Mul(double a, double b);
        }
    interface IDivision
        {
            double Div(double a, double b);
        }

    class Child_Class : IAddition, ISubtraction, IMultiplication, IDivision
        {
            public double Add(double a, double b)
            {
                return a + b;
            }
            public double Sub(double a, double b)
            {
                return a - b;
            }
            public double Mul(double a, double b)
            {
                return a * b;
            }
            public double Div(double a, double b)
            {
                if (b == 0)
                    {                     
                    Console.WriteLine("Cannot be divided by Zero 0");
                    return 0;
                    }

            else
                return a / b;
            }
        }

    internal class Plaindrome
    {
        public double findplaindrom(int a)
        {
            string string_number = Convert.ToString(a);
            char[] chararray = string_number.ToCharArray();     //Change to the array of character 
            Array.Reverse(chararray);                           //Char of array has reverse built in function 
            //string reversed_string = string_number.Reverse();    
            Console.WriteLine(chararray);
            //Console.WriteLine(reversed_string);
            return 0;
        }
    }

   

}
