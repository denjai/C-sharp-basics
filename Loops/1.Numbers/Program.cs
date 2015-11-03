using System;

namespace _1.Numbers
{
    class Program
    {
        static void Main()
        {

            string input = Console.ReadLine();
            int n = int.Parse(input);
            for (int i = 0; i < n; i++)
            {
                Console.Write(" "+i);
            }
            Console.WriteLine(" ");
        }
    }
}
