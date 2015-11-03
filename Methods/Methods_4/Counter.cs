using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_4
{
    class Counter
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 3, 1, 4, 1, 42, 5, 6, 6, 6, 2 };
            Console.WriteLine(CountNumber(array, 6));
        }
        static int CountNumber(int[] array, int number)
        {
            int count=0;
            foreach (var value in array)
            {
                if (value == number)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
