using System;

class CharStringBoolean
{
    static void Main(string[] args)
    {
        Char c = 'A';
        String s = "안녕하세요";
        Boolean b = true;

        Console.WriteLine("{0}\n{1}\n{2}", c, s, b);
        Console.WriteLine($"{c}\n{s}\n{b}");
    }
}