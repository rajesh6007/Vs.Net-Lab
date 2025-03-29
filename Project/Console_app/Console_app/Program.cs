using System.Collections.Specialized;
using Console_app;

internal class Program
{
    private static void Main(string[] args)
    {
       // Console.WriteLine("Hello, World!");

        //string input = Console.ReadLine();
        //Console.WriteLine(input);              //Prints the output in the new line
        //Console.Write(input);
        //Console.Write(input);
        //Console.ReadKey();  //it will make terminal not close unless user gives any input like getch() in c++

        //1. Write a C# program to swap two numbers
        /*
        int num3 = Convert.ToInt32(Console.ReadLine());
        int num4 = Convert.ToInt32(Console.ReadLine());
    
        int temp;
        temp = num3;
        num3 = num4;
        num4 = temp;
        Console.WriteLine("The values of " + num3  + " and " + num4 + " are swaped");
        */

        //2. Write a C# program to find the largest numebr among the three
        /*
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());
        int num3 = Convert.ToInt32(Console.ReadLine());

        if (num1 > num2 && num1 > num3)
        {
            Console.WriteLine("The largest number is " + num1);
        }
        else if (num2 > num1 && num2 > num3)
        {
            Console.WriteLine("The largest number is " + num2);
        }
        else
        {
            Console.WriteLine("The largest number is " + num3);
        }
        */


        //3. Write a C# program to check whether the given number is even or odd
        /*
        int num1 = Convert.ToInt32(Console.ReadLine());
        if (num1 % 2 == 0)
        {
            Console.WriteLine("The number is even");
        }
        else
        {
            Console.WriteLine("The number is odd");
        }
        */

        //4. Write a C# program to calculate the sum if n natural numbers
        /*
        Console.WriteLine("Find the sum of n natural number where n is ");
        int n = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum = sum + i;
        }
        Console.WriteLine("The sum of the " + n + "numbers is " + sum);
        */


        //5. Check if the given year is a leap year or not
        /*
        Console.WriteLine("Enter a year\n");
        int year = Convert.ToInt32(Console.ReadLine());
        CheckLeapYear obj1 = new CheckLeapYear();
        bool result = obj1.checkyear(year);

        if (result == true)
            Console.WriteLine("The year is a leap year");
        else
            Console.WriteLine("The year is not a leap year");
        
        */

        //6. Create an array and find the sum of the elements of the array
        /*
        Console.WriteLine("Enter the number of element of an array\n");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        int sum = 0;
        Console.WriteLine("Enter the elements of the array\n");
        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
            sum += arr[i];
        }

        Console.WriteLine("The sum of the elements of an arrays are: " + sum);

        */

        //7. Write a C# program to find the factorial of a number

        /*
        findfactorial obj2 = new findfactorial();
        int n = Convert.ToInt32(Console.ReadLine());
        int fact = obj2.factorial(n);
        Console.WriteLine("The factorail of the numeber " + n + "is: " + fact);
        */

        //8. Write a C# program to find if the number is prime numeber or not
        
        findprimenumber obj3 = new findprimenumber();
        int n = Convert.ToInt32(Console.ReadLine());
        bool result = obj3.prime(n);
        if (result == true)
            Console.WriteLine("The given number " + n + " is not a " + "Prime number");
        else
            Console.WriteLine("The given number " + n + " is not a " + "Prime number");

        
    }
}