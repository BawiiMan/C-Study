using System;

class InputName
{
    static void Main(string[] args)
    {
        Console.Write("이름을 입력하시오 => "); //[1] "이름을 입력하시오" 출력
        string name = Console.ReadLine();   //[2] 입력받은 문자열을 name변수에 저장
        Console.WriteLine("안녕하세요. {0}님.", name);    //[3] name 변수 값을 {0}에 출력
    }
}