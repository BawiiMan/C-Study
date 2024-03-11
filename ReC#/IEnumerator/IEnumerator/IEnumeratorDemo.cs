using System;
using System.Collections;

class IEnumeratorDemo
{
    static void Main(string[] args)
    {
        string[] names = { "닷넷콜리아", "비주얼아카데미" };

        //[1] foreach 문으로 출력
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        //[2]IEnumerator 인터페이스를 사용한 데이터 출력: foreach 문과 동일
        IEnumerator list = names.GetEnumerator();   //하나씩 열거
        while (list.MoveNext()) //값이 있는 동안 반복
        {
            Console.WriteLine(list.Current);    //현재 반복 중인 데이터 출력
        }
    }
}