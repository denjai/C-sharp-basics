using System;

namespace _3num
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("a=");
            double a;
            double.TryParse(Console.ReadLine(),out a);
            Console.WriteLine("b=");
            double b; 
            double.TryParse(Console.ReadLine(),out b);
            Console.WriteLine("c=");
            double c;
            double.TryParse(Console.ReadLine(), out c);
            Console.WriteLine("{0}+{1}+{2}={3}",a,b,c,a+b+c);

        }
    }
}
