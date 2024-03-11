using System;

public class CateGoryClass
{
    public void Print(int i) => Console.WriteLine($"카테고리 {i}");
}

class ClassArray
{
    static void Main(string[] args)
    {
        CateGoryClass[] categories = new CateGoryClass[3];  //[1]클래스 배열 생성

        //[2] 각 요소에 인스턴스 생성
        categories[0] = new CateGoryClass();
        categories[1] = new CateGoryClass();
        categories[2] = new CateGoryClass();

        for (int i = 0; i < categories.Length; i++)
        {
            categories[i].Print(i);
        }
    }
}