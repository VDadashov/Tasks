using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    internal abstract class Product
    {
        public Product()
        {
            Count++;
            _no = Count;
        }

        int _no;
        public string Name;
        public double Price;
        private static int Count;

        public int No
        {
            get => _no;
        }

    }
}
