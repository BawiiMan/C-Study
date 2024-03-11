using System;

class VariableSameValue
{
    static void Main(string[] args)
    {
        int a, b, c;
        a = b = c = 10; //변수 여러 개를 선언하고 동일한 값으로 초기화

        Console.WriteLine("{0}, {1}, {2}", a, b, c);
    }
}