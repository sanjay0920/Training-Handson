using System;
namespace handson
{

    delegate string delegate_method(string str);
    class delegate_test2
    {
        public static void welcome(string name)
        {
            Console.WriteLine("Hello  " + name + " !");
        }

        public static void Main(string[] args)
        {

            string str1;

            Console.Write("Please input a name : ");
            str1 = Console.ReadLine();
            welcome(str1);

        }
    }
}
