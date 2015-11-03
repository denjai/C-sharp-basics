using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_3
{
    class EnglishDigit
    {
        static void Main(string[] args)
        {

            Console.Write(NumberToDigit(1029));

        }
        static string NumberToDigit(int number)
        {
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            int last_digit = number % 10;
            return digits[last_digit];

        }
    }
}
