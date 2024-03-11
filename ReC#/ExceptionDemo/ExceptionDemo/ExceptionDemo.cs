using System;

class ExceptionDemo
{
    static void Main(string[] args)
    {
        try
        {
            int[] arr = new int[2];
            arr[100] = 1234;
        }
        catch (Exception ex)    //ex 변수에는 상세한 예외 정보가 담김
        {
            Console.WriteLine(ex.Message);
        }
    }
}