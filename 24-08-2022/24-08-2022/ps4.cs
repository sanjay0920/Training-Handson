using System;

namespace Application
{
    class ps4
    {
        static void Main(string[] args)
        {
            string s1 = "Welcome to the world of C# Programming";
            string[] s2 = s1.Split('#');
            foreach (string s3 in s2)
               
            {
                Console.WriteLine(s3);


            }
            Console.ReadLine();
        }
    }

}
