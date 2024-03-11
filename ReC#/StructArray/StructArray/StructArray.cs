using System;

namespace StructArray
{
    struct BusinessCard //[1] 구조체 선언
    {
        public string Name;
        public int Age;
    }

    class StructArray
    {
        static void Print(string name, int age) // 출력 전담 함수
            => Console.WriteLine($"{name}은(는) {age}살입니다.");

        static void Main(string[] args)
        {
            BusinessCard biz;   //구조체 형식 변수 선언
            biz.Name = "백승수";
            biz.Age = 17;
            Print(biz.Name, biz.Age);

            BusinessCard[] names = new BusinessCard[2]; // 구조체 형식 배열 선언
            names[0].Name = "이세영"; names[0].Age = 102;
            names[1].Name = "권경민"; names[1].Age = 31;
            for (int i = 0; i < names.Length; i++)
            {
                Print(names[i].Name, names[i].Age);
            }
        }
    }
}