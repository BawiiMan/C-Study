using System;
using System.Collections;    //주요 자료 구조 관련 클래스들

class StackNote
{
    static void Main(string[] args)
    {
        Stack stack = new Stack();  //[1] Stack 클래스의 인스턴스 생성

        stack.Push("첫 번째"); //[2] 데이터 입력
        stack.Push("두 번째");
        stack.Push("세 번째");

        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());

        //비어 있는 스택에서 Pop() 요청하면 에러
        try
        {
            Console.WriteLine(stack.Pop()); //언더플로 에러
        }
        catch (Exception ex)
        {
            Console.WriteLine($"예외 내용 : {ex.Message}");
        }
    }
}