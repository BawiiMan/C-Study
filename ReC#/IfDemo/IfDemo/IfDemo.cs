using System;

class IfDemo
{
    static void Main(string[] args)
    {
        int x = 20;

        if (x == 10)
        {
            Console.WriteLine($"x는 {x}입니다.");
        }

        if (x != 20)
        {
            Console.WriteLine($"x는 20이 아닙니다.");
        }
    }
}