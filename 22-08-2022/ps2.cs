using System;
namespace application
{
    class program
    {
        static void Main(string[] args)
        {
            int i, n;
            int[] a = new int[100];
            Console.Write("Input the number of element store in the array :");
            n = Convert.ToInt32(Console.ReadLine());


            Console.Write("Input {0} number of elements in the array :", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write(" array are : ");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", a[i]);
            }

            Console.Write("array in reverse are :");
            for (i = n - 1; i >= 0; i--)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.Write("");
        }
    }
}