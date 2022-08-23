using System;
namespace application
{
    class program
    {
        static void Main(string[] args)
        {
            int i, n, sum = 0;
            Console.Write("enter number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("The odd numbers are :");
            for (i = 1; i <= n; i++)
            {
                Console.Write("{0} ", 2 * i - 1);
                sum += 2 * i - 1;
            }
        }
    }
}
