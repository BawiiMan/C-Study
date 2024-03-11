using System;

class ConditionalOperator
{
    static void Main(string[] args)
    {
        int number = 3;

        //number가 짝수이면 result 변수에 "짝수"를 담고, 그렇지 않으면 "홀수" 담기
        string result = (number % 2 == 0) ? "짝수" : "홀수";

        Console.WriteLine($"{number}은(는) {result}입니다.");
    }
}