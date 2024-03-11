using System;

class Var
{
    static void Main(string[] args)
    {
        var name = "C#";    //string 형식으로 변환함
        Console.WriteLine(name);

        var version = 8.0;  //double 형식으로 변환함
        Console.WriteLine("{0:0.0}", version);
    }
}