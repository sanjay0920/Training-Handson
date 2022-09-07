using System;
delegate void dele(string s);
class program
{
    static void Hello(string s)
    {
        System.Console.WriteLine("  Hello, {0}!", s);
    }

    static void Welcome(string s)
    {
        System.Console.WriteLine("  Welcome {0}!", s);
    }

    static void Main()
    {
        dele firstdel, secondDel;
        firstdel = Hello;
        secondDel = Welcome;

        {
            Console.WriteLine("firstdel:");
            firstdel("Sanjay");
        }
        {
            Console.WriteLine("secondDel:");
            secondDel("Sanjay");

        }
        Console.ReadLine();
    }
}