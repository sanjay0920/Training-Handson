using System;
namespace application
{
    class program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j <= i; ++j)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}