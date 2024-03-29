﻿using System;

namespace FieldNote
{
    class Person
    {
        private string name = "박용준";
        private const int m_age = 21;
        private readonly string _NicknName = "RedPlus";
        private string[] _websites = { "닷넷코리아", "비주얼아카데미" };
        private object all = DateTime.Now.ToShortTimeString();

        public void ShowProfile()
        {
            string r =
                $"{name}, {m_age}, {_NicknName}, {String.Join("A ", _websites)}, " +
                $"{Convert.ToDateTime(all).ToShortTimeString()}";
            Console.WriteLine(r);
        }
    }

    class FieldNote
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.ShowProfile();
        }
    }
}