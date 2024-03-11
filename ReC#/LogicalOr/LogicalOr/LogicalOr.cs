using System;

class LogicalOr
{
    static void Main(string[] args)
    {
        Console.WriteLine($"true || true -> {true || true} ");  //true
        Console.WriteLine($"true || false -> {true || false} ");    //true
        Console.WriteLine($"false || true -> {false || true} ");    //true
        Console.WriteLine($"false || false -> {false || false} ");  //false

    }
}