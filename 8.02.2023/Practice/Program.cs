using System;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human= new Human();

            human.Age = -13;
            human.Age = 78;


            Console.WriteLine(human.Age);

            Student student= new Student();

            student.Age = 13;
            student.Age = 23;

            Console.WriteLine(student.Age);
            
        }
    }
}
