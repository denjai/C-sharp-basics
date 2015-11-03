using System;

namespace _3.PlayCard
{
    class PlayCards
    {
        static void Main()
        {
            Console.WriteLine("Enter play card sign:");
            string s = Console.ReadLine();
            switch (s)
            {
                case "1":
                case "2":
                case "3": 
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "10":
                case "A":
                case "J":
                case "Q":
                case "K":
                    Console.WriteLine("yes");break;
                default:
                    Console.WriteLine("no");
                    break;
            }
        }
    }
}
