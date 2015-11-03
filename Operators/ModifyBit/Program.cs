using System;

namespace ModifyBit
{
    class Program
    {
        static void Main()
        {
            int num=0;
            int num2=1;
            int p = 9;
            int n = 1;
            if(n==1)
            {
                num2<<=p;
                num |= num2;
            }
            else
            {
                num2 <<= p;
                num &= ~num2;
            }

            Console.WriteLine(num);

        }
    }
}
