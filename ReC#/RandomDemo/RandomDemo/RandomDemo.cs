using System;

class RandomDemo
{
    static void Main(string[] args)
    {
        Random random = new Random();   //Random 클래스의 인스턴스 생성
        Console.WriteLine(random.Next());   //임의의 정수
        Console.WriteLine(random.Next(5));  //0~4
        Console.WriteLine(random.Next(1, 10));  //1~9
        Console.WriteLine(random.Next(-10, 0));  //1~9

    }
}