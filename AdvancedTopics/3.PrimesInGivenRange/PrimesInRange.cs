using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.PrimesInGivenRange
{
    class PrimesInRange
    {
        static void Main()
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            PrintList(FindPrimesInRange(start,end));
        }
        static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            List<int> primes = new List<int>(1);     
            for (int i = startNum; i < endNum; i++)
            {
               if(IsPrime(i))
                        primes.Add(i);
            }
            return primes;
        }
        static Boolean IsPrime(int n)
        {
            if (n == 1 || n == 0)
                return false;
            while (true)
            {
                int temp = (int)Math.Round(Math.Sqrt(n));
                for (int i = 2; i <= temp; i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
        static void PrintList(List<int> l)
        {
            int i=0;
            foreach (var item in l)
            {
                if(i%12==0)
                    Console.WriteLine();
                Console.Write("{0,3}, ",item);
                i++;
            }
            Console.WriteLine();
        }
    }
}
