using System;
namespace application
{
    class program
    {
        enum deptnames
        {
            purchase = 1, sales = 2, training = 3, accounting = 4
        }
        static void Main(string[] args)
        {
            int n = (int)deptnames.purchase;
            Console.WriteLine(n);
        }
    }
}