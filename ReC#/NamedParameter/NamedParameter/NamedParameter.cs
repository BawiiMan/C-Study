using System;

class NamedParameter
{
    static void Main(string[] args)
    {
        Sum(10, 20);    //기본 형태
        Sum(first: 10, second: 20); //[1] 매개변수 이름과 콜론(:) 기호를 사용하여 호출
        Sum(second: 20, first: 10);  //[2] 매개변수 이름을 지정하면 변수 위치 변경 가능
    }

    static void Sum(int first, int second)  //명명된 매개변수
    {
        Console.WriteLine(first + second);
    }
}