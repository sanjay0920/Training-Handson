﻿using System;
namespace application
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number");
            int b = Convert.ToInt32(Console.ReadLine());
            add(a, b);

        }
        static void add(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine("sum is"+sum);
        }
    }
}