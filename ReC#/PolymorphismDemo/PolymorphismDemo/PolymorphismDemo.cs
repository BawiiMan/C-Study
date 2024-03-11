using System;

namespace PolymorphismDemo
{
    //[1] Animal 클래스: 추상 클래스 및 기본 클래스
    public abstract class Animal
    {
        //동물들은 '울다'라는 기능이 있어야 한다고 맹세
        public abstract string Cry();
    }
    //[2] Dog 클래스
    public class Dog : Animal
    {
        public override string Cry() => "멍멍멍";
    }
    //[3] Cat 클래스
    public class Cat : Animal
    {
        public override string Cry() => "야옹";
    }
    //[4] Trainer 클래스
    public class Trainer
    {
        public void DoCry(Animal animal)
        {
            //뭐가 실행? Dog? Cat? => 모른다(컴파일 시점),
            //언제? 런타임에 Dog/Cat을 알 수 있음
            Console.WriteLine("{0}", animal.Cry()); //다형성: dynamic(동적)
        }
    }

    class PolymorphismDemo
    {
        static void Main(string[] args)
        {
            //[a] 기본 개체 생성 방법
            Console.WriteLine(new Dog().Cry());
            Console.WriteLine(new Cat().Cry());

            Console.WriteLine();

            //[b] 부모 클래스 변수로 개체 생성
            Animal dog = new Dog();
            Console.WriteLine(dog.Cry());
            Animal cat = new Cat();
            Console.WriteLine(cat.Cry());

            Console.WriteLine();

            //[c]다형성 테스트
            //동일한 Cry 메서드를 호출하지만,
            //넘겨준 메시지에 따라 서로 다른 유형의 기능 구현
            //그러한 다형성은 메서드 오버라이드로 구현
            Trainer trainer = new Trainer();
            trainer.DoCry(new Dog());
            trainer.DoCry(new Cat());

        }
    }

}