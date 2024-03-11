using System;

class BreakInfiniteLoop
{
    static void Main(string[] args)
    {
        int number = 0;

        while (true)    //무한 루프
        {
            Console.WriteLine(++number);

            if (number >= 5)
            {
                break;
            }
        }
    }
}