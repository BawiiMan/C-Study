using System;

class CommandLineDemo
{
    static void Main(string[] args)
    {
        int first = int.Parse(args[0]);//1
        int second = Convert.ToInt32(args[1]);  //2
        Console.WriteLine(first + second);   // 1+ 2 = 3;
    }
}