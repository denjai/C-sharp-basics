using System;

namespace oddOrEven
{
    class OddOrEven
    {
        static void Main()
        {
            Console.WriteLine("Enter number to see if its odd:");
            short t =(short) Console.Read();
            if (t%2==0)
            {
                Console.WriteLine("The number is not odd - FALSE");
            }
            else Console.WriteLine("The number is odd - True");
        }
    }
}
