using System;

class ReturnValue
{
    static string GetString()
    {
        return "반환값(Return Value)"; //return 키워드로 단순 문자열 반환
    }

    static void Main()
    {
        string returnValue = GetString();   //함수 호출
        //Console.WriteLine(returnValue);
    }
}