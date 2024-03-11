using System;

class ReadLineCharacter
{
    static void Main(string[] args)
    {
        Console.Write("문자를 입력하세요 : ");
        string input = Console.ReadLine();  //문자열 입력
        char c = Convert.ToChar(input); //문자로 변환
        Console.WriteLine(c);
    }
}