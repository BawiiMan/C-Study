using System;
using System.Linq;

class MaxAlgorithm
{
    static void Main(string[] args)
    {
        //[1] 초기화
        int max = int.MinValue; //정수 형식의 데이터 중 값이 작은 값으로 초기화

        //[2] 입력
        int[] numbers = { -2, -5, -3, -7, -1 };

        //[3] 처리: Max
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];   //Max: 더 큰 값으로 할당
            }
        }

        //[4] 출력
        Console.WriteLine($"최댓값(식) : {numbers.Max()}");
        Console.WriteLine($"최댓밗(문) : {max}");


    }
    
}