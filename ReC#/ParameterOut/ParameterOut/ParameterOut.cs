using System;

class ParameterOut
{
    static void Main(string[] args)
    {
        int num; //.변수를 반드시 초기화할 필요는 없음

        Do(out num);

        Console.WriteLine($"[2] {num}");
    }

    static void Do(out int num)
    {
        num = 1234; //ref와 동일: 호출한 부분에 적용, 반드시 초기화해야 함
        Console.WriteLine($"[1] {num}");    //1234;
    }
}