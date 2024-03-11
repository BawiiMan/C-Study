using System;
using System.Collections.Generic;

class GenericPros
{
    static void Main(string[] args)
    {
        /* [1] Stack클래스
        Stack stack = new Stack();
        stack.Push(3840);
        int width = (int)stack.Pop();
        Console.WriteLine(width);
        */

        /* [2] Stack 제네릭
        Stack<int> stack = new Stack<int>();
        stack.Push(2160);
        int height = stack.Pop();
        Console.WriteLine(height);
        */

        /* [1]배열 사용
        int[] arrNumbers = new int[2];
        arrNumbers[0] = 10;
        arrNumbers[1] = 20;
        for (int i = 0; i < arrNumbers.Length; i++)
        {
            Console.WriteLine(arrNumbers[i]);
        }
        */

        /* [2]List<T>제네릭 클래스
        List<int> lstNumbers = new List<int>();
        lstNumbers.Add(30);
        lstNumbers.Add(40);
        for (int i = 0; i < lstNumbers.Count; i++)
        {
            Console.WriteLine(lstNumbers[i]);
        }
        */

        List<string> colors = new List<string>();
        colors.Add("Red");
        colors.Add("Green");
        colors.Add("Blue");

        for (int i = 0; i < colors.Count; i++)
        {
            Console.Write($"{colors[i]}\t");

        }
        Console.WriteLine();
        foreach (string color in colors)
        {
            Console.Write($"{color}\t");
        }
        
    }
}