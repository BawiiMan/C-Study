﻿using System;

class ForEach
{
    static void Main(string[] args)
    {
        string str = "ABC123";

        foreach (char c in str)
        {
            Console.Write($"{c}\t");
        }
        Console.WriteLine();
    }
}