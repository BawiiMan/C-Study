using In = Korea.Incheon;   //Korea.Incheon 네임스페이스를 In 네임스페이스를 별칭으로 붙여 이용
using Korea.Seoul;  //Korea.Seoul 네임스페이스의 클래스를 바로 사용 가능
using System;

namespace Korea
{
    namespace Seoul
    {
        public class Car
        {
            public void Run() => Console.WriteLine("서울 자동차가 달립니다.");
        }
    }

    namespace Incheon
    {
        public class Car
        {
            public void Run() => Console.WriteLine("인천 자동차가 달립니다.");
        }
    }

    namespace NamespaceDescription
    {
        class NamespaceDescription
        {
            static void Main(string[] args)
            {
                Korea.Seoul.Car s = new Korea.Seoul.Car();
                s.Run();

                Korea.Incheon.Car i = new Korea.Incheon.Car();
                i.Run();

                Car seoul = new Car();

                In.Car ic = new In.Car();
                ic.Run();
            }
        }
    }
}