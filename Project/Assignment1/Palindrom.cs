using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Palindrom
    {
        public void checkPalindrom() 
        {
            Console.WriteLine("Enter a number to check if it is palindrom");
            string num = Console.ReadLine();

            if (IsPalindrom(num))
            { 
                Console.WriteLine("The number is a palindrom");
            }
            else
            {
                Console.WriteLine("The number is not a palindrom");
            }

        }

        public bool IsPalindrom(string num)
        {
            int length = num.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (num[i] != num[length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
    