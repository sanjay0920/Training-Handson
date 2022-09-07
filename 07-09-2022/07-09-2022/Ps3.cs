using System;

delegate void MyDel(int num1, int num2);
class Program
{
    static void Add(int num1, int num2)
    {
        Console.WriteLine("\tAddition: " + (num1 + num2));
    }

    static void Sub(int num1, int num2)
    {
        Console.WriteLine("\tSubtraction: " + (num1 - num2));
    }

    static void Main()
    {
        int num1 = 0;
        int num2 = 0;

        MyDel del = new MyDel(Add);

        Console.Write("Enter the value of num1: ");
        num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the value of num2: ");
        num2 = int.Parse(Console.ReadLine());

        del += new MyDel(Sub);

        Console.WriteLine("Value 1:");
        del(num1, num2);

        del -= new MyDel(Sub);
        Console.WriteLine("Value  2:");
        del(num1, num2);

    }
}
