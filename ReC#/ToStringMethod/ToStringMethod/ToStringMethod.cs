using System;

class My { }

class Your
{
    public override string ToString()
    {
        return "새로운 반환 문자열 지정";
    }
}
class ToStringMethod
{
    static void Main(string[] args)
    {
        My my = new My();
        Console.WriteLine(my);   //"My": 개체를 출력하면 기본은 클래스 이름이 출력
        
        Your your = new Your();
        Console.WriteLine(your);
    }
}
