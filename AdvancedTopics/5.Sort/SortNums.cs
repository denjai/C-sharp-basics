﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5.Sort
{
    class SortNums
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
             Array.Sort(numbers);
             foreach (var item in numbers)
             {
                 Console.WriteLine(item);   
             }

        }
    }
}
