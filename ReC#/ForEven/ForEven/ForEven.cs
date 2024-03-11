using System;

class ForEven
{
    static void Main(string[] args)
    {
        //[1] 입력
        int sum = 0;

        //[2] 처리: 주어진 범위(for 문)에 주어진 조건(if 문)
        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 0) //짝수만 필터링
            {
                sum += i;
            }
        }

        //[3] 출력
        Console.WriteLine($"1부터 100까지 짝수의 합 : {sum}");
    }
}