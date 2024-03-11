using System;

class ArrayOne4
{
    static void Main(string[] args)
    {
        //1차원 배열 선언, 요소 생성, 초기화를 동시에...
        //new 키워드와 int[] 생략하고 바로 초기화 가능
        int[] intArray = { 1, 2, 3 };

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"{i}번재의 인덱스 : {intArray[i]}");
        }

        foreach (int intValue in intArray)
        {
            Console.WriteLine("{0}", intValue);
        }
    }
}