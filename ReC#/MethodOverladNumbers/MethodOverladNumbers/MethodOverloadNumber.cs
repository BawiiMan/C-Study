using System;

class MMethodOverlaodNumber
{
    static void GetNumber(int number)   //GetNumber 함수: int 매개변수
    {
        Console.WriteLine($"Int32 : {number}");
    }

    static void GetNumber(long number)  //GetNumber 함수: long 매개변수
    {
        Console.WriteLine($"Int64 : {number}");
    }

    static void Main(string[] args)
    {
        GetNumber(1234);
        GetNumber(1234L);
    }
}