using System;

namespace EncapsulationNote
{
    public class Person
    {
        //[1] 필드
        private string name;
        //[2] 메서드: public 메서드 또는 속성으로 외부에 공개
        public void SetName(string n) => name = n;
        public string GetName() => this.name;
    }

    class EncapsulationNote
    {
        static void Main(string[] args)
        {
            //[a] person 개체 생성
            Person person = new Person();
            //[b] Set 메서드로 필드 설정
            person.SetName("C#");
            //[c] Get 메서드로 필드 공개
            Console.WriteLine(person.GetName());
        }
    }
}