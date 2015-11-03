using System;

namespace _2.DivisibleBy7and3
{
    class Divisible
    {
        static void Main()
        {
            string s = Console.ReadLine();
            int n = int.Parse(s);
            for (int i = 0; i <= n; i++)
            {
                if(i%7==0&&i%3==0)
                {
                    Console.WriteLine(i+" ");
                }
            }
        }
    }
}
