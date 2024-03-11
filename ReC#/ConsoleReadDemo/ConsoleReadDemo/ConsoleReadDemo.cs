using System;

class ConsoleReadDemo
{
    static void Main(string[] args)
    {
        int x = Console.Read(); //[1] 콘솔에서 문자 하나를 입력한 후 [Enter]
        Console.WriteLine(x);   //[2] A를 입력했다면 A에 해당하는 정수 값 65 출력
        Console.WriteLine(Convert.ToChar(x));   //[3] 65에 해당하는 유니코드 문자 출력
    }
}