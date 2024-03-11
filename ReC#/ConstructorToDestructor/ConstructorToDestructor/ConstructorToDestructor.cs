using static System.Console;

public class DestructorTest
{
    public DestructorTest()
    {
        WriteLine("[1] 생성");
    }

    public void Run()
    {
        WriteLine("[2] 실행");
    }

    ~DestructorTest()
    {
        WriteLine("[3] 소멸");
    }
}
class ConstructorToDestructor
{
    static void Main(string[] args)
    {
        DestructorTest test = new DestructorTest();
        test.Run();
        GC.Collect();
    }
}