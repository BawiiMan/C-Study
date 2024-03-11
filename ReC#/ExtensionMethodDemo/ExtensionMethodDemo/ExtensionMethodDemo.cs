using System;

namespace ExtensionMethodDemo
{
    public static class MyClass
    {
        public static int WordCount(this String str)
        {
            return str.Split(new char[] { ' ', '.', '?'},
                StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }

    class ExtensionMethodDemo
    {
        static void Main(string[] args)
        {
            string s = "안녕하세요?";
            Console.WriteLine(s.Length);    //문자 개수
            Console.WriteLine(s.WordCount());   //단어 개수
        }
    }
}