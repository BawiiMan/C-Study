using System;

namespace PropertyAll
{
    public class Car
    {
        private string color;   //필드

        public Car()
        {
            this.color = "Black";
        }

        public void SetColor(string color)
        {
            this.color = color;
        }

        public string GetColor()
        {
            return color;
        }

        //속성
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public string Make
        {
            get { return "한국자동차"; }
        }

        //쓰기 전용 속성
        private string _Type;
        public string Type
        {
            set { _Type = value; }
        }

        //축약형 속성
        public string Name { get; set; }
    }

    class PropertyAll
    {
        static void Main(string[] args)
        {
            //[1] Set과 Get 메서드 사용
            Car car1 = new Car();
            car1.SetColor("Red");
            Console.WriteLine(car1.GetColor()); //Red

            //[2] 속성을 사용
            Car whiteCar = new Car();
            whiteCar.Color = "White";   //set{}
            Console.WriteLine(whiteCar.Color);    //get{}

            //[3] 읽기 전용 속성
            Car k = new Car();
            Console.WriteLine(k.Make);

            //[4] 쓰기 전용 속성
            Car car = new Car();
            car.Type = "중형";

            //[5] 축약형 속성
            Car myCar = new Car();
            myCar.Name = "좋은차";
            Console.WriteLine(myCar.Name);
        }
    }
}