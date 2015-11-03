using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6.LongestArea
{
    class AreaInArray
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] array=new string[n];
            int count = 1;
            Dictionary<string, int> element = new Dictionary<string, int>();
            for (int i = 0; i < n; i++)

            {
                array[i] = Console.ReadLine();
            }

            for (int i = 0; i < n-1; i++)
            {
                if (array[i].Equals(array[i + 1]))
                {
                    count++;
                }
                else
                {
                    element.Add(array[i], count);
                    count = 1;
                }       
            }

            element.Add(array[n-1],count);
            int temp=0;
            string key="";
            foreach (var ele in element)
            {
                if (temp < ele.Value)
                {
                    temp = ele.Value;
                    key = ele.Key;
                }
            }

            Console.WriteLine(temp);
            for (int i = 0; i < temp; i++)
            {
                Console.WriteLine(key);
            }

        }
    }
}
