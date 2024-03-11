using System;

class WhileDemo
{
    static void Main(string[] args)
    {
        int i = 1;  //초기식부터
        while (i <= 5)  //초기식을 만족하는 동안
        {
            Console.WriteLine("카운트 : {0}", i);  //실행문을 실행하고
            i++;    //증감식을 사용하여 인덱스 변수를 1씩 증가
        }
    }
}