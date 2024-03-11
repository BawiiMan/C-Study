using System;

class ReadLineRealNumber
{
    static void Main(string[] args)
    {
        Console.Write("실수를 입력하세요 : ");
        string input = Console.ReadLine();  //실수 입력
        double PI = Convert.ToDouble(input);    //실수로 변환
        Console.WriteLine(PI);
    }
}