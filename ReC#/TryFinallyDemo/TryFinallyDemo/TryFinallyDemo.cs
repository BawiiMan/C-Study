using System;

class TryFinallyDemo
{
    static void Main(string[] args)
    {
        Console.WriteLine("[1] 시작");

		try//예외가 발생할 만한 구문이 들어오는 곳
		{
            Console.WriteLine("[2] 실행");
            throw new Exception();  //무작정 에러 발생
        }
		finally 
        {
            Console.WriteLine("[3] 종료");
        }
    }
}