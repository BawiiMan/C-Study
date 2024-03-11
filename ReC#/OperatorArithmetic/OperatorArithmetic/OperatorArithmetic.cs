using System;

class OperatorArithmetic
{
    static void Main(string[] args)
    {
        int a = 5;
        int b = 3;
        Console.WriteLine(a + b);
        Console.WriteLine(a - b);
        Console.WriteLine(a * b);
        Console.WriteLine(a / b);

        Console.WriteLine("{0} % {1} = {2}", a, b, (a % b));
    }
}