using System;

class RecursionPower
{
    static int MyPower(int num, int cnt)
    {
        if (cnt == 0)
        {
            return 1;
        }
        return num * MyPower(num, --cnt);// 2 * (2* (1))
    }

    static void Main(string[] args)
    {
        Console.WriteLine(MyPower(2, 2));   //2 * 2 * 1 = 4
    }
}