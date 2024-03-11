using System;

class PassMethodAsParameter
{
    //[1] 입력한 문자열 길이를 반호나하는 메서드
    static int StringLength(string data) => data.Length;

    //[2] 매개변수 string이고 반환값이 int인 메서드를 매개변수로 받아 사용
    static void StringLengthPrint(Func<string, int> stringLength, string message)
        => Console.WriteLine($"메시지의 크기는 {stringLength(message)}입니다.");

    //[a] 메서드의 매개변수로 특정 메서드(StringLength) 전달
    static void Main() => StringLengthPrint(StringLength, "안녕하세요.");
}