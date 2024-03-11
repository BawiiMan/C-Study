using System;

class ExpressionBodiedMethod
{
    static void Main(string[] args)
    {
        Log("함수 축약");   //아래에 함수를 먼저 만들고 호출해야 함
        Console.WriteLine(IsSame("A", "A"));
    }

    static void Log(string message) => Console.WriteLine(message);
    static bool IsSame(string a, string b) => a == b;
}