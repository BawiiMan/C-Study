class ClassDemo
{
    static void Main(string[] args)
    {
        //다른 클래스의 멤버 호출
        ClassOne.Hi();
        ClassTwo.Hi();

        ClassTwo ct = new ClassTwo();
        ct.Hello();
    }
}