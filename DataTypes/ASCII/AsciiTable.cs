using System;

namespace ASCII
{
    class AsciiTable
    {
        static void Main(string[] args)
        {
            short i;
            for ( i = 0; i < 255; i++)
            {
                string hexVlaue = i.ToString("X");
                Console.WriteLine("DEC:{0} Char:{1} Hex:{2}",i,(char)i,hexVlaue);
                
            }
        }
    }
}
