﻿using System;
using System.Collections;
public class program
{
    public static void Main(string[] args)
    {
        Hashtable numberNames = new Hashtable();
        numberNames.Add(1, "One");
        numberNames.Add(2, "Two");
        numberNames.Add(3, "Three");
        foreach (DictionaryEntry de in numberNames)
            Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);
        Console.ReadLine();
    }
}