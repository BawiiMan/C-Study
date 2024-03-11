using System;

class IntToByte
{
    static void Main(string[] args)
    {
        int x = 255;
        byte y = (byte)x;

        Console.WriteLine($"{x} -> {y}");   //보간된 문자열을 사용하여 x와 y의 값 출력
    }
}