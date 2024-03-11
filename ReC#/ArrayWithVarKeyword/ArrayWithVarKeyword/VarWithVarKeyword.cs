using System;

class ArrayWithVarKeyword
{
    static void Main(string[] args)
    {
        var i = 5; //자동으로 정수 형식이 설정됨 -> int i = 5;
        Console.WriteLine("i : {0}, 타입 : {1}", i, i.GetType());

        var s = "Hello";    //문자열 형식으로 형식화됨
        Console.WriteLine("S : {0}, 타입 {1}", s, s.GetType());

        var numbers = new int[] { 1, 2, 3 };    //배열 형식
        foreach (var item in numbers)   //var item에서 item은 numbers 형식
        {
            Console.WriteLine("item : {0}, 타입 : {1}", item, item.GetType());
        }
    }
}