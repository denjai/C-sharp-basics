using System;

namespace _3.MinMaxSum
{
    class NumbersSS
    {
        static void Main()
        {
            string s = Console.ReadLine();
            int n = int.Parse(s);
            int max = int.MinValue, min = int.MaxValue, sum=0, number;
            for (int i = 0; i < n; i++)
            {
                s = Console.ReadLine();
                number = int.Parse(s);
                if (number > max)
                    max = number;
                if (number < min)
                    min = number;
                sum += number;
            }
            Console.WriteLine("min =  {0}",min);
            Console.WriteLine("max = {0}",max);
            Console.WriteLine("sum = {0}",sum);
            Console.WriteLine("avg = {0:F2}",(float)sum/n);
        }
    }
}
