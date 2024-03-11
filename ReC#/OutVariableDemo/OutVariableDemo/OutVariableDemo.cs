using System;

class OutVariableDemo
{
    static void Main(string[] args)
    {
        if (DateTime.TryParse("2023/12/25", out var xmas))
        {
            Console.WriteLine(xmas);
        }
    }
}