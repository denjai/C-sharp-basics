using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 4,2,8,4,5,7,9,2,6};
            Console.WriteLine(Neighbours(0, array)); 
        }
        static bool Neighbours(int index, int[] array)
        {
            int length = array.Length;
            if(index>array.Length-2||index<1)
            {
                return false;
            }
            if (array[index] > array[index + 1] && array[index] > array[index - 1])
            {
                return true;
            }
            else return false; 
        }
    }
}
