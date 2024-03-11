using System;

class AutoPropertyInitializers
{
    public static string Name { get; set; } = "길벗";
    static void Main(string[] args)
    {
        Console.WriteLine(Name);
    }
}