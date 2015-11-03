using System;
namespace PrimeNumber
{
    class PrimeNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number to check if its prime:");
            string str=Console.ReadLine();
            int number;
            Int32.TryParse(str,out number);
            if(number%2==0 && number!=2)
            {
                Console.WriteLine( "The number is not prime");
            }
            else
            {
                int res = (int)Math.Sqrt(number);
                for (int i = 3; i < res; i++)
                {
                    if (number % i == 0)
                    {
                        Console.WriteLine("The number is not prime!");
                        return;
                    }
                }
                Console.WriteLine("The number is prime");
            }
        }
    }
}
