using System;

namespace Comaparing
{
    class Compare
    {
        static void Main()
        {
            float a =5.00000001f;
            float b = 5.00000003f;
            float esp = 0.000001f;
            Compare testing = new Compare();
            Console.WriteLine(testing.equal(a,b,esp));
        }
        public bool equal(float a, float b, float esp)
        {
            if ((a - b) < esp)
                return true;
            else return false;
        }
    }
}
