﻿using System;

class IntegerDemo
{
    static void Main(string[] args)
    {
        int min = -2147483648;  //정수형이 가질 수 있는 최솟값
        int max = +2147483647;  //정수형이 가질 수 있는 최댓값

        Console.WriteLine("int 변수의 최솟값 : {0}", min);
        Console.WriteLine("int 변수의 최댓값 : {0}", max);
    }
}