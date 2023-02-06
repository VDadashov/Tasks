using System;

namespace Practice
{
    internal class Human
    {
        public Human(string fullname)
        {
            Console.WriteLine("Human yaradildi");
            FullName = fullname;
            Age = 16;
        }
        public Human(string fullname, byte age)
        {
            Console.WriteLine("Human yaradildi");
            FullName = fullname;
            Age = age;
        }
        public string FullName;
        public byte Age;
    }
}
