using System;

class DoWhile
{
    static void Main(string[] args)
    {
        int count = 4;  //초기식
        do
        {
            Console.WriteLine("안녕하세요.");    //실행문
            count++;    //증감식
        } while (count < 3);
    }
}