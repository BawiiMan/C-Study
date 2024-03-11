using System;

class BinaryString
{
    static void Main(string[] args)
    {
        byte x = 10;    //0000 1010

        Console.WriteLine($"십진수: {x} -> 이진수: {Convert.ToString(10, 2).PadLeft(8, '0')}");
    }
}