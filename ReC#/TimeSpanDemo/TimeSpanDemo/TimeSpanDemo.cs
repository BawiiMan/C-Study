using System;

class TimeSpanDemo
{
    static void Main(string[] args)
    {
        //시간 차(D-Day) 구하기 : TimeSpan 구조체
        TimeSpan dday = Convert.ToDateTime("2023-12-25") - DateTime.Now;
        Console.WriteLine($"{DateTime.Now.Year}년도 크리스마스는 {(int)dday.TotalDays}일 남음");

        //지난 시간 구하기
        TimeSpan times = DateTime.Now - Convert.ToDateTime("1999-05-04");
        Console.WriteLine($"내가 지금까지 며칠 살아왔는지? {(int)times.TotalDays}");
    }
}