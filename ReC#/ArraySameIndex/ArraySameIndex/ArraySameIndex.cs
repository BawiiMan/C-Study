using System;

class ArraySameIndex
{
    static void Main(string[] args)
    {
        int[,] arr = new int[3, 3];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (i == j)
                {
                    arr[i, j] = 1;  //행과 열이 같으면 1로 채우기
                }
                else
                {
                    arr[i, j] = 0;
                }

                Console.Write(arr[i, j]);
            }
            Console.WriteLine();
        }
    }
}