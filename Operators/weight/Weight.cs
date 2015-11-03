using System;

namespace weight
{
    class Weight
    {
        static void Main()
        {
            Console.WriteLine("Enter weight:");
            string s = Console.ReadLine();
            int w;
            Int32.TryParse(s, out w);
            Console.WriteLine("the weigth on the moon is : {0}",w*(17.000/100));
            Console.Read();
        }
    }
}
