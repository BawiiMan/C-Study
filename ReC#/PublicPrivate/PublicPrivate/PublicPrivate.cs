using System;

public class TestClass
{
    private static string name = "백승수"; //private
    public static string siteName = "길벗";   //public

    public static string GetName()
    {
        return name;
    }
}
class PublicPrivate
{
    static void Main(string[] args)
    {
        Console.WriteLine(TestClass.siteName);

        Console.WriteLine(TestClass.GetName());
    }
}