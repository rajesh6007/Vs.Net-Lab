
using System.ComponentModel;
using Assignment1;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Performing MathOperations using functions overloading");

        MathOperations MO = new MathOperations();
        Console.WriteLine("Addition :" + MO.Add(10, 5));
        Console.WriteLine("Subtraction :" + MO.Subtract(10, 5));
        Console.WriteLine("Multiplication :" + MO.Multiply(10, 5));
        Console.WriteLine("Division :" + MO.Divide(10, 5));

        Console.WriteLine("\n\nPerforming MathOperations using Multiple Inheritance and function overriding");
        MathOperation inheritance = new MathOperation();
        Console.WriteLine("Addition :" + inheritance.Addition(10, 5));
        Console.WriteLine("Subtraction :" + inheritance.Subtract(10, 5));
        Console.WriteLine("Multiplication :" + inheritance.Multiply(10, 5));
        Console.WriteLine("Division :" + inheritance.Divide(10, 5));

        Console.WriteLine("\n\nTo check whether the number given by user is Palindrom or not");
        Palindrom checkPalindrom = new Palindrom();
        checkPalindrom.checkPalindrom();
    }
}