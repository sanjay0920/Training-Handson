using System;
namespace application
{
    class program
    {
        static void Main(string[] args)
        {
            int i, n, sum = 0;
            int[] a = new int[100];
            Console.Write("Input the number of elements in the array :");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                sum += a[i];
            }

            Console.Write("Sum of all elements  in the array is : {0}", sum);
        }
    }
}