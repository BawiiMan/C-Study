using System;
using System.Numerics;

class IfNested
{
    static void Main(string[] args)
    {
        string name = "C#";
        int version = 8;

        if (name == "C#")   //첫 번째 조건
        {
            if (version == 8)   //두 번째 조건
            {
                Console.WriteLine($"{name} {version}");
            }
        }
    }
}