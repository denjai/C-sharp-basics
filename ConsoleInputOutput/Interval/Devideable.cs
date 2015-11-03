using System;

namespace Interval
{
    class Devideable
    {
        static void Main()
        {
            Console.Write("min=");
            string s = Console.ReadLine();
            int min = int.Parse(s);

            Console.Write("max=");
             s = Console.ReadLine();
            int max = int.Parse(s);

            Console.Write("Devidable by :");
            s = Console.ReadLine();
            int dev = int.Parse(s);

            int p = 0;
            for (int i = min; i < max; i++)
            {
                if (i % dev == 0)
                    p++;
            }
            Console.WriteLine("Number of devidable numbers is {0}",p);
        }
    }
}
