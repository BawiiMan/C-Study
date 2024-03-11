using System;

class FunctionCall
{
    static void Hi()    //[1] 함수 만들기(정의, 선언)
    {
        Console.WriteLine("안녕하세요.");
    }

    static void Main(string[] args)
    {
        Hi(); Hi(); Hi();   //[2] 함수 사용하기(호출): 여러 번 호출
    }
}