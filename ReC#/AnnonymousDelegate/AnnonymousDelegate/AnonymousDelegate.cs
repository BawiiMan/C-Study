using System;

class AnonymousDelegate
{
    delegate void SayDelegate();
    static void Main(string[] args)
    {
        SayDelegate say = delegate ()
        {
            Console.WriteLine("반갑습니다.");
        };
        say();
    }
}