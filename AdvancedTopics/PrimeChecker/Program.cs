using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPrime(323));
            Console.WriteLine(IsPrime(337));

        }
        static Boolean IsPrime(int n)
        {
            if (n == 1 || n == 0)
                return false;
            while (true)
            {
                int temp = (int)Math.Round( Math.Sqrt(n));
                for (int i = 2; i<=temp; i++)
                {
                    if (n%i==0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
