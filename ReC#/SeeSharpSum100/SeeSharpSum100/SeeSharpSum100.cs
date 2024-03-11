using System;

class SeeSharpSum100
{
    static void Main(string[] args)
    {
        //입력
        int sum = 0;

        //처리
        for (int i = 1; i <= 100; i++)
        {
            sum += i;   //sum = sum + i;
        }

        //출력
        Console.WriteLine("1부터 100까지 정수의 합 : {0}", sum);
    }
}