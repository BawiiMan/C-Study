using System;

class If
{
    static void Main(string[] args)
    {
        int score = 50;

        if (score >= 60)    //score가 60 이상이면 '합격' 출력
        {
            Console.WriteLine("합격");
        }
        else
        {
            Console.WriteLine("불합격");
        }
    }
}