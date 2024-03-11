using System;

class DefaultParameter
{
    static void Main(string[] args)
    {
        Log("디버그"); //두 번째 매개변수 생략
        Log("에러", 4);   // 전체 매개변수 사용

        //[1] 기본 매개변수(선택적 매개변수): 매개변수 선언과 동시에 초기화
        static void Log(string message, byte level = 1)
        {
            Console.WriteLine($"{message}, {level}");
        }
    }
}