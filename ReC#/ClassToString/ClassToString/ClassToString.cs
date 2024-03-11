using System;

namespace ClassToString
{
    class Person
    {
        private string name;
        public Person(string name)  //생성자
        {
            this.name = name;
        }

        //ToString() 메서드 오버라이드(재정의)
        public override string ToString() => $"[Person 클래스 : {this.name}]";
    }

    class ClassToString
    {
        static void Main(string[] args)
        {
            Person person = new Person("박민승");
            Console.WriteLine(person);
        }
    }
    
}