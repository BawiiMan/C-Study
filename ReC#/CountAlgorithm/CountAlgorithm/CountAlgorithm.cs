using System;
using System.Linq;

class CountAlgoritm
{
    static void Main(string[] args)
    {
        //[1] 입력: 1부터 1000까지 데이터
        var numbers = Enumerable.Range(1, 1_000).ToArray(); //1 ~ 1000
        int count = default;    //개수를 저장할 변수는 0으로 초기화

        //[2] 처리: 개수 알고리즘 영역: 주어진 범위에 주어진 조건(필터링)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 13 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"1부터 1000까지 정수 중 13의 배수 개수 : {count}");
        }
    }
}