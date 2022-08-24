using System;
namespace Application
{
    class Program
    {
        static void Main()
        {
            String str = "convert to uppercase";
            String result = str.ToUpper();
            Console.WriteLine($"String  : {str}");
            Console.WriteLine($"Uppercase String : {result}");
        }
    }

}
