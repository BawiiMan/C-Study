﻿using System;

class WhileDecrement
{
    static void Main(string[] args)
    {
        int index = 5;
        while (index > 0)
        {
            Console.WriteLine($"안녕하세요. {index}");
            index--;
        }
    }
}