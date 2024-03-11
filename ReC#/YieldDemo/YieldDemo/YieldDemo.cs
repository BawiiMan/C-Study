using System;
using System.Collections;

class YieldDemo
{
    static IEnumerable GetNumbers()
    {
        yield return 1;
        yield return 2;
        for (int i = 3; i <=  5; i++)
        {
            yield return i; //반복해서 호출 가능
        }
    }

    static void Main(string[] args)
    {
        foreach (int num in GetNumbers())
        {
            Console.Write($"{num}\t");
        }
        Console.WriteLine();
    }
}