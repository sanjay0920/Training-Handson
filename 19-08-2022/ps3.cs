using System;
namespace application
{
    class Program
    {
        static void Main(string[] args)

        {
            string s1, s2;

            Console.WriteLine("Enter the first character : ");
            s1 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter the second character : ");
            s2 = Convert.ToString(Console.ReadLine());

            if (s1 == s2)
                Console.WriteLine("characters are equal");
            else
                Console.WriteLine("Characters are not equal");
        }
    }
}
