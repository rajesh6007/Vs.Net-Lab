using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_app
{
    internal class CheckLeapYear()
    {
        public bool checkyear(int year)
        {
            if (year % 4 == 0 && year % 100 != 0)
                return true;
            else if (year % 4 == 0 && year % 100 == 0 && year % 400 == 0)
                return true;
            else
                return false;
        }
    }

    class findfactorial()
        {
        public int factorial(int n)
            {
                if (n == 0)
                    return 1;
                else
                    return n * factorial(n - 1);
            }
        }

    class findprimenumber()
        {
            public bool prime(int n)
                {
                    if (n == 1)
                        return false;

                    for (int i = 2; i <= n / 2; i++)
                        {
                            if (n % i == 0)
                                return false;
                        }
                        return true;
                }
        }
}
