using System;

namespace bitwise3
{
    class Bitwise
    {
        static void Main()
        {

            int five = 5;
            five&=0x0008;
            if(five==8)
            {
                Console.WriteLine(1);
            }
            else
                Console.WriteLine(0);

        }
    }
}
