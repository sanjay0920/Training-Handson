using System;
namespace application
{
    class program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int i;
            Console.Write("Input 10 elements in the array :");
            for (i = 0; i < 10; i++)
            {
                Console.Write("element - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Elements in array are: ");
            for (i = 0; i < 10; i++)
            {
                Console.Write("{0}  ", arr[i]);
            }
            Console.Write("");
        }
    }
}