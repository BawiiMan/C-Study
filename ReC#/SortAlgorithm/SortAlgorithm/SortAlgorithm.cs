using System;

class SortAlgorithm
{
    static void Main(string[] args)
    {
        //[1] 입력 : Data Structure(Array, List, Stack, Queue, Tree, DB, ...)
        int[] data = { 3, 2, 1, 5, 4 };
        int N = data.Length;

        //[2] 처리: 선택 정렬 알고리즘
        for (int i = 0; i < N - 1; i++) //i = 0 to N-1
        {
           for (int j = i + 1; j < N; j++)  //j = i + 1 to N
           {
                if (data[i] > data[j])  //부등호 방향: 오름차순(>), 내림차순(<)
                {
                    int temp = data[i];
                    data[i] = data[j];
                    data[j] = temp;
                }
           }
        }
        //[3] 출력: Console, Desktop, Web, Mobile, ...
        for (int i = 0; i < N ; i++)
        {
            Console.Write($"{data[i]}\t");
        }
        Console.WriteLine();
        
    }
}