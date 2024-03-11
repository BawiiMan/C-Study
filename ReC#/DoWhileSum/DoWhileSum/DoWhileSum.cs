using System;

class DoWhileSum
{
    static void Main(string[] args)
    {
        int sum = 0;

        int i = 1;  //초기식
        do
        {
            sum += i;   //실행문
            i++;    //증감식
        } while (i <= 5);   //조건식

        Console.WriteLine($"합계 : {sum}");
    }
}