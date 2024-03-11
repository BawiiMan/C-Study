using System;

class LocalFunctionDemo
{
    static void Main(string[] args)
    {
        void Display(string text)   //Main 메소드 내부의 함수(로컬 함수)
        {
            Console.WriteLine(text);
        }

        Display("로컬 함수");
    }
}