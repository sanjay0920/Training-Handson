using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace application
{
    class ps2
    {
        static void Main(string[] args)
        {
            String str1;
            String str2;

            Console.Write("Enter string : ");
            str1 = Console.ReadLine();
            str2 = String.Copy(str1);


            Console.WriteLine("Value is str1 : " + str1);
            Console.WriteLine("Value of str2 : " + str2);
        }
    }
}
