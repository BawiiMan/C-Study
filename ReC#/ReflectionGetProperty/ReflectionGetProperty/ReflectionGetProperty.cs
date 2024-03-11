using System;
using System.Reflection;

namespace ReflectionGetProperty
{
    class Person
    {
        [Obsolete] public string Name { get; set; }
    }

    class ReflectionGetProperty
    {
        static void Main(string[] args)
        {
            //Name 속성의 정보 얻기
            PropertyInfo pi = typeof(Person).GetProperty("Name");

            //Name 속성에 적용된 특성 읽어 오기
            object[] attributes = pi.GetCustomAttributes(false);
            foreach (var attr in attributes)
            {
                //특성들 이름들 출력
                Console.WriteLine("{0}", attr.GetType().Name);
            }
        }
    }
}