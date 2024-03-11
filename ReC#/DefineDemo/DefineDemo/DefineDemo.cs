#define YES

using System;
class DefineDemo
{
    static void Main(string[] args)
    {
#if YES
        Console.WriteLine("YES");

#else
        Console.WritLine("No");
#endif
    }

}