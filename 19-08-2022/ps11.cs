using System;
namespace application
{
    class program
    {
        static void Main(string[] args)
        {
            int i, sum = 0;
            Console.Write("Numbers between 100 and 200 : ");
            for (i = 101; i < 200; i++)
            {


                Console.Write("{0}  ", i);
                sum += i;

            }
            Console.Write("The sum : {0} ", sum);
        }
    }
}