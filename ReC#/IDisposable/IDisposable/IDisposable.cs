using System;

class IDisposible
{
    static void Main(string[] args)
    {
        Console.WriteLine("[1] 열기");
        using (var t = new Toilet())
        {
            //특정 프로세스를 종료하면 자동으로 닫기 수행
            Console.WriteLine("[2] 사용");
        }
    }
}

public class Toilet : IDisposable
{
    public void Dispose()
    {
        Console.WriteLine("[3] 닫기"); 
    }
}