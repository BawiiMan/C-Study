﻿using System;

namespace InterfaceNote
{
    //[1] ICar 인터페이스 선언
    interface ICar
    {
            void Go();  //메서드 시그니처만 제공
    }

    //[2] ICar 인터페이스를 상속하는 Car클래스 선언
    class Car : ICar
    {
        public void Go() => Console.WriteLine(
            "상속한 인터페이스에 정의된 모든 멤버를 반드시 구현해야 한다.");
    }

    class InterfaceNote
    {
        static void Main(string[] args)
        {
            var car = new Car();
            car.Go();
        }
    }
}