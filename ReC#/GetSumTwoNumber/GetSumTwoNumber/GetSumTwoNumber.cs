using System;

class GetSumTwoNumber
{
    static double GetSum(double x, double y)    //두 수의 합을 구하는 함수(메서드)
    {
        double r = x + y;
        return r;
    }

    static void Main(string[] args)
    {
        double result = GetSum(3.0, 0.14);
        Console.WriteLine(result);
    }
}