using System;

class ArrayGetLengthDemo
{
    static void Main(string[] args)
    {
        //3차원 배열 선언(요소 개수 생성), 초기화(층/행/열)
        int[,,] arr = new int[2, 2, 2]
            { { { 1, 2 }, { 3, 4 } }, { { 5, 6 }, { 6, 7 } } };
        Console.WriteLine("차수 출력 : {0}", arr.Rank);
        Console.WriteLine("길이 출력 : {0}", arr.Length);

        for (int  i = 0; i < arr.GetLength(0); i++) //층
        {
            for (int j = 0; j < arr.GetLength(1); j++)  //행
            {
                for(int k = 0; k < arr.GetLength(2); k++)   //열
                {
                    Console.Write("{0}\t", arr[i, j, k]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}