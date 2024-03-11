using System;

class EnumParse
{
    static void Main(string[] args)
    {
        string color = "Blue";   //열거형에 없는 상수 문자열을 지정하면 예외

        //[1] 문자열로 지정 문자열에 해당하는 열거 상수 가져오기
        Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), color);

        Console.WriteLine("Red");
        Console.ResetColor();
    }
}