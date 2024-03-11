using System;

class BitwiseOperator
{
    static void Main(string[] args)
    {
        var x = Convert.ToInt32("1010", 2);
        var y = Convert.ToInt32("0110", 2);

        var and = x & y;    //0010
        Console.WriteLine($"{and} : {Convert.ToString(and, 2).PadLeft(4, '0')}");

        var or = x | y; //1110
        Console.WriteLine($"{or} : {Convert.ToString(or, 2)}");

        var xor = x ^ y;
        Console.WriteLine($"{xor} : {Convert.ToString(xor, 2)}");

        var not = ~x;   //2의 보수법에 따라서 1010 + 1그리고 부호를 -로 -1011 => -11
        Console.WriteLine($"{not} : {Convert.ToString(not, 2)}");
    }
}