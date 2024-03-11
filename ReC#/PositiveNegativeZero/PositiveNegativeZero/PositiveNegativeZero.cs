using System;

class PositiveNegativeZero
{
    static void Main(string[] args)
    {
        //int number = -10;   //[1] 원하는 정수 데이터 입력
        int number = Convert.ToInt32(Console.ReadLine());

        if (number > 0) //[a] 양수인지 판단
        {
            Console.WriteLine($"{number}은 양수입니다.");
        }
        else if (number < 0)    //[b] 음수인지 판단
        {
            Console.WriteLine($"{number}은 음수입니다."); //*
        }
        else
        {
            Console.WriteLine($"{number}은 0입니다.");
        }
    }
}