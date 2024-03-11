using System;

class ParamsDemo
{
    static void Main(string[] args)
    {
        Console.WriteLine(SumAll(3, 5));    //8
        Console.WriteLine(SumAll(3, 5, 7)); //15
        Console.WriteLine(SumAll(3, 5, 7, 9));  //24


    }

    static int SumAll(params int[] numbers)
    {
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        return sum;
    }
}