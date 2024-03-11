using System;

class ParameterRef
{
    static void Main(string[] args)
    {
        int num = 10;
        Console.WriteLine($"[1] {num}");    //[1]

        Do(ref num);

        Console.WriteLine($"[3] {num}");
    }

    static void Do(ref int num)
    {
        num = 20;   //호출한 부분에 적용 Main메소드 num 변수 값 변경
        Console.WriteLine($"[2] {num}");
    }
}