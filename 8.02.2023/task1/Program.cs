using System;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car()
            {
                Brand = "BMW",
                Model = "M4",
                Millage = 200,
                FullCapacity = 500,
            };

            car.Showinfo();
            Console.WriteLine("--------------------");

            Bicycle bicycle = new Bicycle() 
            {
                Millage = 300,
                Brand = "Diamond Back",
                Model = "MBX"
            };

            bicycle.Showinfo();
            Console.WriteLine("--------------------");

        }
    }
}
