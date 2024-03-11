using System;
using static System.Console;
using static System.Math;

class UsingStaticClassesDemo
{
    static void Main(string[] args)
    {
        //[1] 기본 사용 방식
        WriteLine(Math.Pow(2, 10));

        //[2] using  static 지시문으로 줄여서 표현
        WriteLine(Math.Pow(2, 10));
        WriteLine(Max(3, 5));
    }
}