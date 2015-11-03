using System;


namespace Methods
{
    class Methods
    {
        static void Say_hello()
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Hello , {0}.",name);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Say_hello();
        }
    }
}
