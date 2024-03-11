using System;

class TimesTable
{
    static void Main(string[] args)
    {
        for (int i = 2; i <= 9; i++)
        {
            Console.Write($"{i, 5}단");
        }
        Console.WriteLine();

        for (int i = 1; i <= 9; i++)    //행(세로) 출력
        {
            for (int j = 2; j <= 9; j++)    //열(가로) 출력
            {
                Console.Write($"{j}*{i}={j * i, 2} ");
            }
            Console.WriteLine();
        }
    }
}