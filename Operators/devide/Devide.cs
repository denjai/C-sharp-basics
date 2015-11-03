using System;

namespace devide
{
    class Devide
    {
        static void Main()
        {
            Console.WriteLine("Devide by 5 or 7? Enter number:");
            string num = Console.ReadLine();
            int ss;
            Int32.TryParse(num,out ss);
            if(ss%5==0 && ss%7==0)
                Console.WriteLine("True");
        }
    }
}
