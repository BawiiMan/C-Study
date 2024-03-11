using System;
using System.Text.RegularExpressions;

class RegexDemo
{
    static void Main(string[] args)
    {
        string email = "rockyman0504@naver.com";
        Console.WriteLine(IsEmail(email));
    }

    static bool IsEmail(string email)
    {
        bool result = false;

        //[1] 이메일ㅇ르 검사하는 정규식은 인터넷에서 검색하여 사용가능
        Regex regex = new Regex(@"^([0-9a-zA-Z]+)@([0-9a-zA-Z]+)(\.[0-9a-zA-Z]+){1,}$");

        result = regex.IsMatch(email);  //패턴이 맞으면 true

        return result;
    }
}