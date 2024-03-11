using System;
using System.Diagnostics;
using System.Threading;

class StopwatchDemo
{
    static void Main(string[] args)
    {
        Stopwatch timer = new Stopwatch();  //인스턴스화
        timer.Start();
        LongTimePrecess();
        timer.Stop();

        //밀리초 단위로 표시
        Console.WriteLine("경과 시간 : {0}밀리초", timer.Elapsed.TotalMilliseconds);

        //초 단위로 표시
        Console.WriteLine("경과 시간 : {0}초", timer.Elapsed.Seconds);


    }

    static void LongTimePrecess()
    {
        //3초간 대기: Thread.Sleep() 메서드로 현재 프로그램 3초간 대기
        Thread.Sleep(3000);
    }
}