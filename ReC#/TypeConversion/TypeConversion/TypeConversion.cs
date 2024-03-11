using System;

class TypeConversion
{
    static void Main(string[] args)
    {
        double d = 12.34;
        int i = 1234;

        d = i;  //큰 그릇에 작은 그릇의 값을 저장
        Console.WriteLine("압시적 형식 변환 = " + d);

        d = 12.34;
        i = (int)d; //() 사용: 정수형 데이터만 저장됨
        Console.WriteLine("명시적 형식 변환 = " + i);

        string s = "";
        s = Convert.ToString(d);
        Console.WriteLine("형식 변환 = " + s);
    }
}