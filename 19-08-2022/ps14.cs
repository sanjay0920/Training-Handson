﻿using System;
namespace application
{
    class program
    {
        static void Main(string[] args)
        {
            int item = 5;
            switch (item)
            {

                case 1:
                    Console.WriteLine("case 1");
                    break;

                case 5:
                    Console.WriteLine("case 5");
                    break;

                case 9:
                    Console.WriteLine("case 9");
                    break;

                default:
                    Console.WriteLine("No match found");
                    break;
            }
        }
    }
}