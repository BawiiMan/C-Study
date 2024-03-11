using System;

class MergeAlgorithm
{
    static void Main(string[] args)
    {
        //[1] 입력
        int[] first = { 1, 3, 5 };  //오름차순 정렬됨
        int[] second = { 2, 4 };    //오름차순 정렬됨
        int M = first.Length;
        int N = second.Length;
        int[] merge = new int[M + N];   //병합된 배열
        int i = 0; int j = 0; int k = 0;

        //[2] 처리: MERGE
        while (i < M && j < N)
        {
            if (first[i] <= second[j])
            {
                merge[k++] = first[i++];
            }
            else
            {
                merge[k++] = second[j++];
            }
        }
        while (i < M)   //첫 번째 배열이 끝에 도달할 때까지
        {
            merge[k++] = first[i++];
        }
        while (j < N)   //두 번째 배열이 끝에 도달할 때까지
        {
            merge[k++] = second[j++];
        }

        //[3] 출력
        foreach (var m in merge)
        {
            Console.Write($"{m}\t");
        }
        Console.WriteLine();
    }
}