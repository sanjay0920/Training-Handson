using System;
using System.Collections;
public class program
{
    public static void Main(string[] args)
    {
        Stack s = new Stack();
        s.Push(" bike");
        s.Push(" car ");
        s.Push(" bus ");
        Console.WriteLine("count of stack" + s.Count);
        Console.WriteLine("Element at the top is : " + s.Peek());
        object s1 = s.Pop();
        Console.WriteLine("1st pop:" + s1);
        Console.ReadLine();
    }
}