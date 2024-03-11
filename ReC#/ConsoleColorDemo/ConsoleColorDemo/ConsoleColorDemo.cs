using System;

class ConsoleColorDemo
{
    static void Main(string[] args)
    {
        //전경색
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Blue");
        //Console.WriteLine("RED");
        Console.ResetColor();

        //배경색
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Red");
        Console.WriteLine("Green");
        Console.ResetColor();
    }
}