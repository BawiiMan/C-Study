using System;

public class Original { /* EMPTY */ }

public static class OriginalExtension
{
    public static void NewMethod(this Original original)
        => Console.WriteLine("새로운 메서드 추가");
}

class ExtensionMethodNote
{
    static void Main(string[] args)
    {
        (new Original()).NewMethod();   //확장 메서드 호출
    }
}