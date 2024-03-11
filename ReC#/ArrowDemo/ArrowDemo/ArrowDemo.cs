using System;

class Counter
{
    private int count;  //필드

    public int Count
    {
        get => count;
        set => count = value;
    }

    public void IncreaseCount() => Count++;
}

class ArrowDemo
{
    static Counter counter;
    static void Main(string[] args)
    {
        counter = new Counter();
        counter.IncreaseCount();
        Console.WriteLine($"카운트 : {counter.Count}");
    }
}