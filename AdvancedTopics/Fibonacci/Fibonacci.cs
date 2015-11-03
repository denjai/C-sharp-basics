using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fibonacci
{
    /// <summary>
    /// 
    /// </summary>
    class Fibonacci
    {
        /// <summary>
        /// Fiboncci numbers
        /// </summary>
        public static void Main()
        {
           Console.WriteLine(Fib(4)); 
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static int Fib(int n)
        {
            int a = 1,b=1;
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;

            }
            return a;
        }
    }
}
