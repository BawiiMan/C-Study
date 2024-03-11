using System;

static class ExtensioniFunction2
{
    //static 클래스 내static 메서드의 첫 번째 매개벼수에 this가 붙은 것은 확장 메서드
    static string Three(this string value)
    {
        //특정 문자열 뒤에 이 메서드가 호출되면 문자열 중 3개만 반환
        return value.Substring(0, 3);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("안녕하세요.".Three());
    }
}