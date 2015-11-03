using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_2
{
    class Methods
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int max = GetMax(a, GetMax(b, c));
            Console.WriteLine("Max is: {0}",max);

        }
        static int GetMax(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }
    }

}
