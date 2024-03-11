using System;

class ArrayOne2
{
    static void Main(string[] args)
    {
        //1차원 배열 선언, 요소 생성, 초기화를 동시에...
        int[] intArray = new int[3] { 1, 2, 3 };

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"{i}번째 인덱스 : {intArray[i]}");
        }

        foreach (int intValue in intArray)
        {
            Console.WriteLine("{0}", intValue);
        }
    }
}