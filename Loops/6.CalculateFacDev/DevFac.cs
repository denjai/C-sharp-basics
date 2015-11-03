using System;

namespace _6.CalculateFacDev
{
    class DevFac
    {
        static void Main()
        {
            int k = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int factK=1;
            int factN=1;
            for (int i = 1; i <=n; i++)
            {
                factN*=i;
                if(i<=k)
                    factK*=i;
            }
            Console.WriteLine(factN/factK);
        }
    }
}
