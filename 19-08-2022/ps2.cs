using System;
namespace application
{
    class program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.Write("enter the 1st number:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter the 2nd number:");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter the 3rd number:");
            num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num3)
            {
                if (num1 > num2)
                {
                    Console.Write("1st number is greatest");
                }
                else
                {
                    Console.Write("3rd number is greatest");
                }
            }
            else if (num2 > num3)
                Console.Write("2nd number is greatest");
            else
                Console.Write("3rd number is greatest");

        }
    }
}