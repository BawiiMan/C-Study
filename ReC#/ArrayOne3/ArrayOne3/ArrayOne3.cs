using System;

class ArrayOne3
{
    static void Main(string[] args)
    {
        //1차원 배열 선언, 요소 생성, 초기화를 동시에...
        //요소 개수 생략 가능: 생략하면 뒤에서 지정한 요소 개수만큼 자동 생성
        var intArray = new int[] { 1, 2, 3 };

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"{i}번째 인덱스 : {intArray[i]}");
        }

        foreach (int intValue in intArray)
        {
            Console.WriteLine("{0}", intValue);
            Console.WriteLine("Hello");
        }
    }
}