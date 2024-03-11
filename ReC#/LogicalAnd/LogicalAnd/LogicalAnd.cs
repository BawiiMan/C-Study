using System;

class LogicalAnd
{
    static void Main(string[] args)
    {
        Console.WriteLine($"true && true -> {true && true}");
        Console.WriteLine($"true && false -> {true && false}");
        Console.WriteLine($"false && true -> {false && true}");
        Console.WriteLine($"false && false -> {true && true}");

    }
}