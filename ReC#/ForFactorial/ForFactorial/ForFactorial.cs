using System;

class ForFactorial
{
    static void Main(string[] args)
    {
        int fact = 0;

        for (int i = 1; i <= 4; i++)
        {
            Console.Write($"{i}! -> ");
            fact = 1;   //1로 초기화
            for (int j = 1; j <= i; j++)
            {
                fact = fact * j;    //1 * (1 * 2 * 3 * 4)
            }
            Console.WriteLine($"{fact,2}");
        }
    }
}