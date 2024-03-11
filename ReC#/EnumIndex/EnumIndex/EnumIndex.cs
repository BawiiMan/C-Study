using System;

namespace EnumIndex
{
    enum Animal { Rabbit, Dragon, Snake}

    class EnumIndex
    {
        static void Main(string[] args)
        {
            Animal animal = Animal.Dragon;
            int num = (int)animal;
            string str = animal.ToString();
            Console.WriteLine($"Aninmal.Dragon : {num}, {str}");
        }
    }
}