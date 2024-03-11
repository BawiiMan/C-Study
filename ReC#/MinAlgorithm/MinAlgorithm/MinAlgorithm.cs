using System;
using System.Linq;
using static System.Console;

class MinAlgorithm
{
    static void Main(string[] args)
    {
        var min = Int32.MaxValue; //최댓값 초기화

        //[2] 입력: 이진수로 표현 + 숫자 구분자 사용({2, 5, 3, 7, 1})
        int[] numbers = { 0b0010, 0B_0101, 0b001, 0B_0111, 0b0001 };

        //[3] 처리: MIN
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < min && numbers[i] % 2 == 0)
            {
                min = numbers[i];
            }
        }

        WriteLine($"짝수 최솟값(식) : {numbers.Where(n => n % 2 == 0).Min()}");
        WriteLine($"짝수 최솟값(문) : {min}");
    }
    
}