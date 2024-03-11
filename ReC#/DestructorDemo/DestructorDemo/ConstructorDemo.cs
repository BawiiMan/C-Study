using System;

namespace DestructorDemo
{
    public class Car
    {
        private string _name;
        public string GetName()
        {
            return _name;
        }
        public Car()    //생성자
        {
            _name = "승용차";
        }
        public Car(string name)
        {
            this._name = name;
        }
        ~Car()
        {
            Console.WriteLine("{0} 폐차...", _name);
        }
    }
    class DestructorDemo
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            Console.WriteLine(car1.GetName());
            Car car2 = new Car("캠핑카");
            Console.WriteLine(car2.GetName());
        }
    }
}