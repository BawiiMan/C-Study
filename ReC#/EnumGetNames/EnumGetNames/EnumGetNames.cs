using System;

class EnumGetNames
{
    static void Main(string[] args)
    {
        Type cc = typeof(ConsoleColor);
        string[] colors = Enum.GetNames(cc);

        foreach (var color in colors)
        {
            Console.WriteLine(color);
        }
    }
}