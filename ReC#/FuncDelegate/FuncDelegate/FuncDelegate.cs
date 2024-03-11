using System;

class FuncDelegate
{
    static void Main(string[] args)
    {
        //[1] Add 함수 직접 호출
        Console.WriteLine(Add(3, 5));

        //[2] Func 대리자로 Add 함수 대힌 호출 : 반호나값이 있는 메서드를 대신 호출
        Func<int, int, string> AddDelegate = Add;
        Console.WriteLine(AddDelegate(3, 5));

        //[3] 람다 식(Lamda): 메서드 -> 무명 메서드 -> 람다 식으로 줄여 표현
        Func<int, int, string> AddLambda = (a, b) => (a + b).ToString();
        Console.WriteLine(AddLambda(3, 5));
    }

    //두 수의 합을 문자열로 반환
    static string Add(int a, int b) => (a + b).ToString();
}