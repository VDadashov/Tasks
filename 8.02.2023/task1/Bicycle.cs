using System;
using System.Collections.Generic;
using System.Text;

namespace task1
{
    internal class Bicycle:Vehicle
    {

        public override void Showinfo()
        {
            Console.WriteLine($"Brand: {Brand} - Model: {Model} - Millage: {Millage}");
        }

    }
}
