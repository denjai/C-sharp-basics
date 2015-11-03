using System;
using System.Numerics;
namespace _7.Combination
{
    class Combination
    {
        static void Main()
        {
            int k = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            BigInteger factN=1, factK=1, factNK=1;
            for (int i = 1; i <= n; i++)
            {
                factN *= i;
                if (i<=k)
                {
                    factK *= i; 
                }
                if (i<=(n-k))
                {
                    factNK *= i;
                }
            }
            Console.WriteLine("{0}",factN/(factK*factNK));
        }
    }
}
