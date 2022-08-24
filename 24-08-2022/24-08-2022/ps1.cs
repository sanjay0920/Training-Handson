using System;
namespace application
{
    class ps1
    {
        static void Main(string[] args)
        {
            string s1 = "sanjay";
            string s2 = "bharathi";
            string s3 = "sanjay";

            // Compare strings 
            if (String.Equals(s1, s2))
                Console.WriteLine($"{s1} and {s2} have same value");
            else
                Console.WriteLine($"{s1} and {s2} are different");

            if (String.Equals(s1, s3))
                Console.WriteLine($"{s1} and {s3} have same value");
            else
                Console.WriteLine($"{s1} and {s3} are different");
        }
            
    }
}