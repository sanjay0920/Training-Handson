using System;
using System.Linq;
namespace exercise
{
    delegate string delegate_method(string str);
    class delegate_test
    {
        static void Main(string[] args)
        {
            string str1 = "sanjay bharathi";
            Console.WriteLine("string: " + str1);
            Console.WriteLine("converted string:\n" + test(str1));
           
        }
        public static string test(string str1)
        {
            return string.Join(" ", str1.Split(' ').Select(str1 => char.ToUpper(str1[0]) + str1.Substring(1)));
        }
    }
}
