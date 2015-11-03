using System;

namespace FDigits
{
    class Digits
    {
        static void Main(string[] args)
        {
            int op =2011;
            int num1=op%10;
            op /=10;
            int num2 = op%10;
            op/=10;
            int num3 = op % 10;
            op /= 10;
            int num4 = op % 10;
            Console.WriteLine(num1+num2+num3+num4);
            Console.WriteLine("{0}{1}{2}{3}",num1,num2,num3,num4);
            Console.WriteLine("{0}{1}{2}{3}", num1, num4, num3, num2);
            Console.WriteLine("{0}{1}{2}{3}", num4, num2, num3, num1);
            Console.ReadLine();    
        }
    }
}
