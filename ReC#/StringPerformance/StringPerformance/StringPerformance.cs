using System;

class StringPerformance
{
    static void Main(string[] args)
    {
        DateTime start = DateTime.Now;

        string msg = "";
        for (int i = 0; i < 10000; i++)
        {
            msg += "안녕하세요.";
        }

        DateTime end = DateTime.Now;
        double exec = (end - start).TotalMilliseconds;
        Console.WriteLine(exec);
        //Console.WriteLine(msg); // 출력 확인용
    }
}