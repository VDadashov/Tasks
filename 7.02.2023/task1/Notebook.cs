using System;
using System.Collections.Generic;
using System.Text;

namespace task1
{
    internal class Notebook
    {
        public Notebook(string brand,string model) 
        {
            Console.WriteLine("\nNotebook obyekt'i yaradildi");
            Brand= brand;
            Model= model;
        }

        public string Brand;
        public string Model;
        public int Price;

        public void ShowInfo() 
        {
            Console.WriteLine($"Brand: {Brand} - Model: {Model} - Price: {Price}");
        }
    }
}
