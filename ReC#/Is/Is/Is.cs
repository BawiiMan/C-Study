using System;

class Is
{
    static void Main(string[] args)
    {
        //object x = Convert.ToInt32(Console.ReadLine());

        object x = "Hello";
        if (x is int)
        {
            Console.WriteLine($"{x}는 정수형으로 변환이 가능합니다.");
        }
        else
        {
            Console.WriteLine("불가");
        }
    } 
}