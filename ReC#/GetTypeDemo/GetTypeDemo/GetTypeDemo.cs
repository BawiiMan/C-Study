using System;

class GetTypeDemo
{
    static void Main(string[] args)
    {

        int i = 1234;
        string s = "안녕하세요.";
        char c = 'A';
        double d = 3.14;
        object o = new object();    //개체: 개체를 생성하는 구문
        float f = 3.14f;

        Console.WriteLine(i.GetType());
        Console.WriteLine(s.GetType());
        Console.WriteLine(c.GetType());
        Console.WriteLine(d.GetType());
        Console.WriteLine(o.GetType());
        Console.WriteLine(f.GetType());
    }
}