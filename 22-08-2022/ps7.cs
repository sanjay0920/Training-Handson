﻿using System;
using System.Collections.Generic;

public class program
{
    public static void Main(string[] args)
    {
        Queue myQueue = new Queue();
        myQueue.Enqueue(1);
        myQueue.Enqueue(2);
        myQueue.Enqueue(3);
        myQueue.Enqueue(4);
        Console.Write("Total number of elements in the Queue are : " + myQueue.Count);
        Console.WriteLine("Top element of queue using peek:" + myQueue.Peek());
        Console.WriteLine("Top element of queue using Deqeue:" + myQueue.Dequeue());
        Console.WriteLine("after deqeue the count of myQueue:" + myQueue.Count);
        Console.ReadLine();
    }
}