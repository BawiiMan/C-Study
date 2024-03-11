using System;

class AdditionOperator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello" + "World");   //문자열 더하기
        Console.WriteLine("Hi" + " " + "everyone");

        Console.WriteLine("123" + "456");   //숫자형 문자열은 무자열로 취급
        Console.WriteLine("123" + 456); //문자열과 숫자형은 무자열로 취급
        Console.WriteLine(123 + "456");
        Console.WriteLine(123 + 456);   //숫자끼리는 산술 연산
        Console.WriteLine("123" + true);    //bool 형식과 더하기는 문자열 취급
        
    }
}