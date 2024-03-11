using System;

struct Member   //Member 구조체 선언
{
    public string Name;
    public int Age;
}

class StructParameter
{
    static void Main(string[] args)
    {
        string name = "백승수";    //변수 사용
        int age = 21;
        Print(name, age);   //매개변수를 따로 선언

        Member m;
        m.Name = "이세영";
        m.Age = 100;
        Print(m);   //구조체 매개변수를 사용하여 전다
    }

    static void Print(string name, int age)
        => Console.WriteLine($"이름 : {name}, 나이 : {age}");

    static void Print(Member member)
        => Console.WriteLine($"이름 : {member.Name}, 나이 : {member.Age}");
}