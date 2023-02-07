using System;
using System.Collections.Generic;
using System.Text;

namespace task1
{
    internal class Car:Vehicle
    {
        public int FullCapacity;

        public override void Showinfo()
        {
            Console.WriteLine($"Brand: {Brand} - Model: {Model} - Millage: {Millage} - FullCapacity: {FullCapacity}");
        }
    }
}
