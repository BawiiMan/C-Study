using System;

struct Point
{
    public int X;   //public 키워드로 외부에서 int X 변수를 사용하도록 설정
    public int Y;
}

class StructDemo
{
    static void Main(string[] args)
    {
        Point point;    //Point 구조체 형식의 변수 선언
        point.X = 100;  //점을 구분해서 X 변수에 값을 할당
        point.Y = 200;  //점을 구분해서 Y변수에 값을 할당
        Console.WriteLine($"X : {point.X}, Y : {point.Y}");
    }
}