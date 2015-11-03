using System;

namespace _12.RandomizeNumbers
{
    class Randomize
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers =new int[n+1];
            int printed = 0;
            Random random = new Random();
            while (printed<n)
            {
                int number = random.Next(1, n+1);
                if (numbers[number] != 1)
                {
                    Console.Write(number+" ");
                    printed++;
                    numbers[number] = 1;
                    int[] bers = new int[7];
                 
                }        
            }
            Console.WriteLine("\n\rall numbers printed");
        }
    }
}
