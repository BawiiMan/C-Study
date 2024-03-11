using System;

class BreakDemo
{
    static void Main(string[] args)
    {
        for (int  i = 0; i < 100; i++)
        {
            if (i == 5)
            {
                break;  //i == 5일 때 for 문 종료
            }
            Console.Write($"{(i + 1)}번 반복\t");
        }
        Console.WriteLine();
    }
}