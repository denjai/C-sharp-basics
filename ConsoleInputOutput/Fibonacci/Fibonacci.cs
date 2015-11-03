using System;

namespace Fibonacci
{
    class Fibonacci
    {
        static void Main()
        {
            Console.WriteLine("Enter number n:");
            string s = Console.ReadLine();
            int n=int.Parse(s);
            int a=0,b=1;

            for (int i = 0; i < n; i++)
            {
                int temp = a;
                Console.WriteLine(a);
                a = b;
                b = temp + b;
               
            }
           
        }
    }
}
