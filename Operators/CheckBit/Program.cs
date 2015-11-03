using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckBit
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 15;
            int p = 6;
            Console.WriteLine(((num>>p)&0x0001)==1);
        }
    }
}
