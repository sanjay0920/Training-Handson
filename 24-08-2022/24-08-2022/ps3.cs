using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Application
{
    class Ps3
    {
        static void Main(string[] args)
        {
            String str1;
            String str2;

            Console.Write("Enter string : ");
            str1 = Console.ReadLine();

            Console.Write("Enter sub string : ");
            str2 = Console.ReadLine();

            int index = str1.IndexOf(str2);

            if (index < 0)
                Console.WriteLine("Sub string is not find in string");
            else
                Console.WriteLine("Index str2 in str1 is: " + index);
        }
    }

}
