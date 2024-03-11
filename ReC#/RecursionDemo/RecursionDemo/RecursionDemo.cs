using System;

class RecursionDemo
{
    static void Main(string[] args)
    {
        //재귀 호출을 사용하여 팩토리얼 구하기: 4! = 4 * 3 * 2 * 1 = 24
        Console.WriteLine(4 * 3 * 2 * 1);
        Console.WriteLine(FactorialFor(4));
        Console.WriteLine(Factorial(4));
        Console.WriteLine(Fact(4));
    }

    //3항 연산자를 사용한 팩토리얼 구하기
    static int Fact(int n)
    {
        return (n > 1) ? n * Fact(n - 1) : 1;
    }

    static int Factorial(int n)
    {
        //종료
        if (n == 0 || n == 1)
        {
            return 1;
        }
        return n * Factorial(n - 1);    //재귀 호출
    }

    //단순한 팩토리얼은 이 방법이 좋음
    static int FactorialFor(int n)
    {
        int result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;    //((((1 * 1) * 2) * 3) * 4)
        }
        return result;
    }
}