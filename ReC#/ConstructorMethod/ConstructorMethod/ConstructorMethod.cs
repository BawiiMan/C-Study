using System;

class Student
{
    public Student()
    {
        Console.WriteLine("Student 개체가 생성됩니다.");
    }
}

class ConstructorMethod
{
    static void Main(string[] args)
    {
        Student student;
        student = new Student();
    }
}