using System.ComponentModel;
using System.IO.Enumeration;
using OOP;

internal class Program
{
    private static void Main(string[] args)
    {

        Overloading obj1 = new Overloading();
        int a=5 ,  b=4 ;
        double d = 5.9, e = 4.5;
        int f = 1234;
        /*
        Console.WriteLine("Using overlolading functions"); 

        Console.WriteLine("The Sum of two numbers " + obj1.Add(a, b));

        Console.WriteLine($"The Sum of two numbers  {obj1.Add(d, e)}");

        Console.WriteLine("The Multiply of two numbers " + obj1.Multiply(a, b));

        Console.WriteLine($"The Multiply of two numbers  {obj1.Multiply(d, e)}");

        Console.WriteLine("Using interface fpr multipel Inheritance");
        
        Child_Class obj2 = new Child_Class(); 

        Console.WriteLine("The sum of two numebrs " + obj2.Add(d ,e));

        Console.WriteLine("The Subtraction of two numebrs " + obj2.Sub(d, e));

        Console.WriteLine("The Multiplication of two numebrs " + obj2.Mul(d, e));

        Console.WriteLine("The Division of two numebrs " + obj2.Div(d, e));
        */

        Plaindrome obj3 = new Plaindrome();
        obj3.findplaindrom(f);
        Console.ReadKey();
        

    }
}