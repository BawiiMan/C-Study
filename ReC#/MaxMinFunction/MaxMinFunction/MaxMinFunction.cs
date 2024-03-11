using System;

class MaxMinFunction
{
    static int Max(int x, int y)    //Max 함수: 두 수 중에서 큰 수를 반환시켜 주는 함수
    {
        return (x > y) ? x : y; //3항 연산자로 큰 수 구하기
    }

    static int Min(int x, int y)    //Min 함수: 두 수 중에서 작은 수를 반환시켜 주는 함수
    { 
        //if else 문으로 작은 수 구하기
        if (x < y)
        {
            return x;
        }
        else
        {
            return y;
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine(Max(3, 5));
        Console.WriteLine(Min(-3, -5));
    }
}