using System;
using System.Collections.Generic;
using System.Text;

namespace task1
{
    internal class Car:Vehicle
    {
        public int FullCapacity;
        public double FuelFor1km;

        public override void Showinfo()
        {
            Console.WriteLine($"Brand: {Brand} - Model: {Model} - Millage: {Millage} - FullCapacity: {FullCapacity}");
        }

        public override void Drive(double distance)
        {
            base.Drive(distance);
            double neededFuel = distance / FuelFor1km;

        }
    }
}
