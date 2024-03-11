using System;

class TryCatch
{
    static void Main(string[] args)
    {
        try
        {
            int[] arr = new int[2];
            arr[100] = 1234;    //예외 발생
        }
        catch 
        {
            Console.WriteLine("에러가 발생했습니다.");
        }
    }
}