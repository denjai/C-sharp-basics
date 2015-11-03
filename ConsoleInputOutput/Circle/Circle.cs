using System;

namespace Circle
{
    class Circle
    {
        static void Main()
        {
            Console.WriteLine("Enter the radius of the circle");
            double f;
           if( double.TryParse(Console.ReadLine(),out f))
           {
               Console.WriteLine("the perimeter is : {0:F2}",2*Math.PI*f);
               Console.WriteLine("The area is : {0,20:0.00}",Math.PI*f*f);
           }
        }
    }
}
