using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dates
{
    class Program
    {
        static void Main()
        {
            //System.Globalization.CultureInfo.CreateSpecificCulture("bg-BG");
            string s =Console.ReadLine();
            DateTime date1 = DateTime.Parse(s,System.Globalization.CultureInfo.CreateSpecificCulture("bg-BG"));
            s = Console.ReadLine();
            DateTime date2 = DateTime.Parse(s, System.Globalization.CultureInfo.CreateSpecificCulture("bg-BG"));

            TimeSpan time = date2 - date1;
            Console.WriteLine(time.Days);
        }
    }
}
