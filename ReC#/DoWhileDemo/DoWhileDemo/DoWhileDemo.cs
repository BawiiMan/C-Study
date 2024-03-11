using System;

class DoWhileDemo
{
    static void Main(string[] args)
    {
        int sum = 0;
        int i = 1;  //초기식
        do
        {
            if (i % 3 == 0 && i % 4 == 0)   //필터링(조건식)
            {
                sum += i;   //실행문(문장)
            }
            i++;    //증감식
        } while (i <= 100); //조건식(평가할 식)

        Console.WriteLine(sum);
    }
}