using System;
using System.Linq;

class Map
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        var nums = numbers.Select(it => it * it);

        foreach (int i in nums)
        {
            Console.WriteLine(i);
        }
    }

}