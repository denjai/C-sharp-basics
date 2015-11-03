using System;

namespace _4.MultiplicationSign
{
    class Program
    {
        static void Main()
        {
            float a = 5;
            float b=-7;
            float c=-9;
            int minus=0;
            if (a < 0)
                minus++;
            if (b<0)
            {
                minus++; 
            }
            if (c<0)
            {
                minus++;
            }
            if(minus%2==0)
                Console.WriteLine("+");
            else
            {
                Console.WriteLine("-");
            }

        }
    }
}
