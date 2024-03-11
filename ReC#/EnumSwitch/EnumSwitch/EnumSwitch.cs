﻿using System;

namespace EnunSwitch
{
    enum Animal { Chicken, Dog, Pig }

    class EnumSwitch
    {
        static void Main(string[] args)
        {
            Animal animal = Animal.Pig;

            switch (animal)
            {
                case Animal.Chicken:
                    Console.WriteLine("닭");
                    break;
                case Animal.Dog:
                    Console.WriteLine("개");
                    break;
                case Animal.Pig:
                    Console.WriteLine("돼지");
                    break;
                default:
                    Console.WriteLine("기본값 설정 영역");
                    break;
            }
        }
    }
}