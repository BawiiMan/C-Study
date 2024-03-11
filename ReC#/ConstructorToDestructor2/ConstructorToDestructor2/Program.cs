using System;
using static System.Console;

public class DestructorTest2
{
    public DestructorTest2()
    {
        WriteLine("[1] 생성");
    }

    public void Run()
    {
        WriteLine("[2] 실행");
    }

    ~DestructorTest2()
    {
        WriteLine("[3] 소멸");
    }
}
class ConstructorToDestructor
{
    static void Main(string[] args)
    {
        DestructorTest2 test = new DestructorTest2();
        test.Run();
        //GC.Collect();
    }
}