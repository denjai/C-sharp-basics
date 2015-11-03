using System;

namespace _2.BonusScore
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("enter Score:");
            string s = Console.ReadLine();
            int score = int.Parse(s);
            if (score <= 0 || score > 9)
            {
                Console.WriteLine("Invalid score");
                return;
            }
            if (score>=1&&score<=3)
            {
                score *= 10;
            }
            if (score>=4&&score<=6)
            {
                score *= 100;
            }
            if (score>=7&&score<=9)
            {
                score *= 1000;
            }
            Console.WriteLine("The score is {0}",score);
        }
    }
}
