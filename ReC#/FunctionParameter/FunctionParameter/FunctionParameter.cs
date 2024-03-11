using System;

class FunctionParameter
{
    static void ShowMessage(string message) //매개변수가 있는 함수
    {
        Console.WriteLine(message); //넘어온 매개변수 값을 출력
    }

    static void Main(string[] args)
    {
        ShowMessage("매개변수");    //ShowMessage() 함수에 "매개변수" 문자열 전달
        ShowMessage("Parameter");   //ShowMessage() 함수에 "Parameter" 문자열 전달
    }
}