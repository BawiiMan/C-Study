using System;

class ForEachUp
{
    static void Main(string[] args)
    {
        var str = "ABC123";

        foreach (var c in str)
        {
            Console.Write($"{c}\t");
        }
        Console.WriteLine();
    }
}