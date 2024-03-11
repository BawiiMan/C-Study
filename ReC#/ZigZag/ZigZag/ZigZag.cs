using System;

class ZigZag
{
    static void Main(string[] args)
    {
        //[2][] 형태로 두 번째를 비워 두면 동적으로 자료 n개로 초기화 가능
        int[][] zagArray = new int[2][];

        zagArray[0] = new int[] { 1, 2 };   //0번째 행에 요소2개로 초기화
        zagArray[1] = new int[] { 3, 4, 5 };    //1번째 행에 요소 3개로 초기화

        for (int i = 0; i < 2; i++)
        {
            //n번째 행의 길이만큼 반복: 두 번, 세 번 반복
            for (int j = 0; j < zagArray[i].Length; j++)
            {
                Console.Write($"{zagArray[i][j]}\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}