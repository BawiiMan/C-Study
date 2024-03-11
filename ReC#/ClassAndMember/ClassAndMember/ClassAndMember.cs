using System;

public class ClassName  //[1]-1 클래스 생성
{
    public static void MemberName() //[1]-2 멤버 생성: 메서드 멤버 생성
    {
        Console.WriteLine("클래스의 멤버가 호출되어 실행됩니다.");
    }
}

public class ClassAndMember
{
    public static void Main(string[] args)
    {
        ClassName.MemberName(); //[2]-1 클래스 사용, 정적 멤버 접근
    }
}