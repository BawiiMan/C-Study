﻿namespace PartialClassDemo
{
    class PartialClassDemo
    {
        static void Main(string[] args)
        {
            //Hello 클래스의 개체로 서로 다른 파일의 멤버들 호출 가능
            var hello = new Hello();
            hello.Hi();
            hello.Bye();
        }
    }
}