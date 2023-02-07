using System;
using System.Collections.Generic;
using System.Text;

namespace task1
{
    internal class Vehicle
    {
        public Vehicle() 
        {
            Console.WriteLine("Obyekt yaradildi - Vehicle");
        }

        public string Brand;
        public string Model;
        public int Millage;
        
        public virtual void Showinfo() 
        {
            Console.WriteLine($"Brand: {Brand} - Model: {Model} - Millage: {Millage}");
        }       
    }
}
