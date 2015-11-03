using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7.MatrixPoly
{
    class Matrix
    {
        static void Main()
        {
            int rows=int.Parse(Console.ReadLine());
            int cols=int.Parse(Console.ReadLine());
            char a='a';
            for (int i = 0; i < rows; i++)
            {
                char temp = a;
                for (int j = 0; j < cols; j++)
                {
                    
                    Console.Write("{0}{1}{2}   ",a,temp,a);
                    temp++;
                }
                Console.WriteLine();
               a++;
            }
  
        }
    }
}
