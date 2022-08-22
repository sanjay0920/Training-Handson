using System;
public class ps5
{
    public static void Main()
    {
        int number1, number2, number3;

        Console.Write("Enter first number - ");
        number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number - ");
        number2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter third number - ");
        number3 = Convert.ToInt32(Console.ReadLine());

        Console.Write(" {0}, {1} and {2}, (x+y)·z is {3} and x·y + y·z is {4}\n\n",
            number1, number2, number3, ((number1 + number2) * number3), (number1 * number2 + number2 * number3));
    }
}