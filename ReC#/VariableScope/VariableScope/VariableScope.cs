using System;

class VariableScope
{
    static string globalVariable = "전역변수(필드)";

    static void Main(string[] args)
    {
        string localVariable = "지역 변수"; //[1] 지역 변수
        Console.WriteLine(localVariable);
        Console.WriteLine(globalVariable);
        Test();
    }

    static void Test() => Console.WriteLine(globalVariable);
}