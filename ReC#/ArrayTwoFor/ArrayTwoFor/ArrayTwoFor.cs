using System;

class ArrayTwoFor
{
    static void Main(string[] args)
    {
        int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 } };
        for (int i = 0; i < 2; i++) //이중 for 문으로 2차원 배열 출력
        {
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine($"arr[{i},{j}] = {arr[i, j]}");
            }
        }
    }
}