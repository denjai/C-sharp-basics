using System;

namespace Exchange
{
    class Exchange
    {
        static void Main()
        {
            int a = 5, b = 8, temp;
            temp = b;
            b = a;
            a = temp;
            Console.WriteLine("{0} {1}",a,b);
        }
    }
}
