using System;

namespace FormatingNumbers
{
    class Formating
    {
        static void Main()
        {
            int a;
            float b,c;
            string s,binary;
            Console.Write("a=");
            s=Console.ReadLine();
            int.TryParse(s, out a);

            binary=Convert.ToString(a,2);

            Console.Write("b=");
            s = Console.ReadLine();
            float.TryParse(s, out b);

            Console.Write("c=");
            s = Console.ReadLine();
            float.TryParse(s, out c);

            Console.WriteLine("{0,-10:x} {3} {1,10:F2} {2,-10:F3} ",a,b,c,binary.PadLeft(10,'0'));
        }
       
    }
}
