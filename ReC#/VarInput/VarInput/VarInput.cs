using System;

class VarInput
{
    static void Main(string[] args)
    {
        var s = Console.ReadLine(); //문자열 입력받기
        var c = Convert.ToChar(Console.Read()); //문자 하나 입력받기
        Console.WriteLine($"{s} : {s.GetType()}, {c} : {c.GetType()}");
    }
}