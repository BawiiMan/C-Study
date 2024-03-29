﻿using System;

namespace IsAn
{
    class Vehicle { }
    class Car : Vehicle { }
    class Airplane : Vehicle { }

    class IsAn
    {
        static void Main(string[] args)
        {
            //운송 수단(탈 것) is a Vehicle.
            Vehicle vehicle = new Vehicle();
            //자동차 is a Vehicle.
            Vehicle car = new Car();
            //비행기 is Vehicle.
            Vehicle airplane = new Airplane();

            //개체를 문자열로 출력하면 ToString()메서드가 실행됨
            Console.WriteLine($"{vehicle}, {car}, {airplane}");
        }
    }
}