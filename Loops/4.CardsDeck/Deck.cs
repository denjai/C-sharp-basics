using System;

namespace _4.CardsDeck
{
    class Deck
    {
        static void Main()
        {
            for (int i = 2; i < 15; i++)
            {
                string s = i.ToString();
                switch (i)
                {
                    case 11:
                        s = "J";break;
                    case 12:
                        s = "D";break;
                    case 13:
                        s = "K"; break;
                    case 14:
                        s = "A";break;
                    default:
                        break;
                }
                for (int j = 0; j < 4; j++)
                {
                    switch (j)
                    {
                        case 0:
                            {
                                Console.Write(s + "S" + " "); break;
                            }
                        case 1:
                            Console.Write(s+"D"+" ");break;
                        case 2:
                            Console.Write(s+"H"+" ");break;
                        case 3:
                            Console.Write(s+"SP"+" ");break;
                        default:
                            break;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
