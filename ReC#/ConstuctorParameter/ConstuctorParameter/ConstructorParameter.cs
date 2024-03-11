using System;

namespace ConstructorParameter
{
    class My
    {
        private string _name;
        private int _age;
        public My(string name, int age)
        {
            this._name = name;
            this._age = age;
        }
        public void PrintMy()
        {
            Console.WriteLine($"이름 : {this._name}, 나이 : {this._age}");
        }
    }
    class ConstructorParameter
    {
        static void Main(string[] args)
        {
            My my = new My("백승수", 21);
            my.PrintMy();
        }
    }
}