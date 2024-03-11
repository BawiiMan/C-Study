using System;

class DelegateNote
{
    //[1] 대리자 생성: 매개변수도, 반환값도 없는 함수(메서드)를 담을 수 있는 포인터
    delegate void SayPointer();

    //[2] 샘플 함수 생성
    static void Hello() => Console.WriteLine("Hello Delegate");

    static void Main(string[] args)
    {
        //[a] 대리자의 인스턴스 생성 후 매개변수로 대신 실행할 함수 이름 전달
        SayPointer sayPointer = new SayPointer(Hello);

        //[b] 대리자 인스턴스로 함수 대신 호출하는 두 가지 방법
        sayPointer();
        sayPointer.Invoke();
    }
}