using System;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person()
    {

    }
    public Person(string name, int age)
    {
        Name = name; Age = age;
        Console.WriteLine($"{Name}, {Age}");
    }
}

class ObjectInitializers
{
    static void Main(string[] args)
    {
        //[1] 속성 사용
        Person pp = new Person();
        pp.Name = "이세영";
        pp.Age = 100;
        Console.WriteLine($"{pp.Name}, {pp.Age}");


        //[2]생성자 사용
        Person pc = new Person("백승수", 21);

        //[3] 개체 이니셜라이저 사용
        Person pi = new Person() { Name = "권경민", Age = 30 };
        Console.WriteLine($"{pi.Name}, {pi.Age}");
    }
}