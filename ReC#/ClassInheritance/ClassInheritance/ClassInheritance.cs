using System;

namespace ClassInheritance
{
    public class ParentClass : Object   //[a] 모든 클래스는 Object 클래스에서 상속
    {
        protected void Print1() => Console.WriteLine("부모 클래스에서 정의한 내용");
    }

    public class ChildClass : ParentClass   //[b] 콜론 기호로 부모 클래스 지정
    {
        public void Print2() =>
            base.Print1();  //[c] 자식에서 base키워드로 부모 요소에 접근
    }

    class ClassInheritance : Object
    {
        static void Main(string[] args)
        {
            //[1] 부모 클래스의 인스턴스 생성
            ParentClass p = new ParentClass();
            Console.WriteLine(p.ToString());    //ClassInheritance.ParentClass
            //[2] 자식 클래스의 인스턴스 생성
            ChildClass c = new ChildClass();
            c.Print2();
        }
    }
}