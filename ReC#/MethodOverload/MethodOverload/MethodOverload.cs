using System;

class MethodOverload
{
    static void Hi()    //매개변수가 없는 Hi()함수
    {
        Console.WriteLine("안녕하세요.");
    }

    static void Hi(string msg)  //매개변수가 있는 Hi() 함수
    {
        Console.WriteLine(msg);
    }

    static void Main(string[] args)
    {
        Hi();
        Hi("반갑습니다.");
    }
}