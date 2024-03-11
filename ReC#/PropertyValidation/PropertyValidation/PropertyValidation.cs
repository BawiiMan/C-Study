using System;

namespace PropertyValidation
{
    class Car
    {
        public string Name { get; private set; }
        public Car(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                //빈 값이면 강제로 ArgumentException 예외 발생
                throw new ArgumentNullException();
            }
            this.Name = name;
        }
    }

    class PropertyValidation
    {
        static void Main(string[] args)
        {
            Car car = new Car("자동차");
            Console.WriteLine(car.Name);

            //[2] 예외 발생
            //Console.WriteLine(new Car("").Name);
        }
    }
}