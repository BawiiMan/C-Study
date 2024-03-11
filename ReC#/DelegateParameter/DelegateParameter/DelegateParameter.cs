using System;

class DelegateParameter
{
    delegate void Runner();

    static void Main(string[] args)
    {
        RunnerCall(new Runner(Go));
        RunnerCall(new Runner(Back));
    }

    static void RunnerCall(Runner runner) => runner();  //넘어온 메서드(함수) 실행
    static void Go() => Console.WriteLine("직진");
    static void Back() => Console.WriteLine("후진");
}