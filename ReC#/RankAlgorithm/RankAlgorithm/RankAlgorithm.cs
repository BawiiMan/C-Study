using System;
using System.Linq;

class RankAlgorithm
{
    static void Main(string[] args)
    {
        //[1] 입력
        int[] scores = { 90, 87, 100, 95, 80 }; //등수 : 3, 4, 1, 2, 5
        int[] rankings = Enumerable.Repeat(1, 5).ToArray(); //모두 1로 초기화

        //[2] 처리: RANK
        for (int i = 0; i < scores.Length; i++)
        {
            rankings[i] = 1;    //1등으로 초기화, 순위 배열을 매 회전마다 1등으로 초기화
            for (int j = 0; j <scores.Length; j++)
            {
                if (scores[i] < scores[j])  //현재(i)와 나머지(j) 비교
                {
                    rankings[i]++;  //RANK: 나보다 큰 점수가 나오면 순위 1증가
                }
            }
        }

        for (int i = 0; i < scores.Length; i++)
        {
            Console.WriteLine($"{scores[i], 3}점 : {rankings[i]}등");
        }
    }
}