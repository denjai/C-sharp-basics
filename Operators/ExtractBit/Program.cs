using System;

namespace ExtractBit
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 62241;
            byte p = 11;
            num = num >> p;
            num &= 0x0001;
            if(num==1)
                Console.WriteLine(1);
            else Console.WriteLine(0);
        }

    }
}
