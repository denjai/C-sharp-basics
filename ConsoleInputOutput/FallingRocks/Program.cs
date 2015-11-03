using System;
using System.Threading;

namespace FallingRocks
{
    class Program
    {
        static void Main(string[] args)
        {
            string gnome = "<-   (0)  ->";
            while (true)
            {
                Console.WriteLine("__________________________________");
                Console.WriteLine("|                                |");
                Console.WriteLine("|                                |");
                Console.WriteLine("|                                |");
                Console.WriteLine("|                                |");
                Console.WriteLine("|                                |");
                Console.WriteLine("|                                |");
                Console.WriteLine("|                                |");
                Console.WriteLine("|                                |");
                Console.WriteLine("|                                |");
                Console.WriteLine("|                                |");
                Console.WriteLine("|               {0,15}           |",gnome);
                Console.WriteLine("___________________________________");
                Thread.Sleep(150);
                Console.Clear();
            }

        }
    }
}
