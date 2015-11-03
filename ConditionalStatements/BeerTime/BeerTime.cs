using System;
using System.Globalization;


namespace BeerTime
{
    class BeerTime
    {
        static void Main()
        {
            Console.WriteLine("Enter time:");
            string pattern="hh:mm tt";
            string s = Console.ReadLine();
            DateTime parsedDate;
            if (DateTime.TryParseExact(s,pattern,null,DateTimeStyles.None,out parsedDate))
                Console.WriteLine("the time is : {0:hh:mm tt}",parsedDate);
            else
                Console.WriteLine("error parsing");
        }
    }
}
