using System;

namespace _5.CalculateSum
{
    class Sum
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int fac=1,xPow=1;
            float sum=1;
             for (int i = 1; i <=n; i++)
            {
                xPow *= x;
                fac *= i;
                float temp = (float)fac/(float)xPow;
                sum += temp;
            }
             Console.WriteLine("{0:F5}",sum);
        }
    }
}
