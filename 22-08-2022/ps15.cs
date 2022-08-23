using System;
using System.Collections.Generic;
namespace application
{
    class program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 5, 3, 4, 3, 5, 6 };
            int min = -1;

            HashSet<int> set = new HashSet<int>();
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (set.Contains(arr[i]))
                {
                    min = i;
                }

                else
                {
                    set.Add(arr[i]);
                }
            }
            if (min != -1)
            {
                Console.WriteLine("The first repeating element is " + arr[min]);
            }
            else
            {
                Console.WriteLine("There are no repeating elements");
            }
        }
    }
}