using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class Product
    {
        private string _name;
        private double _price;
        public double DiscountPercent;

        public double Price
        {
            get 
            { 
                return _price; 
            }
            set
            {
                if (value>0)
                {
                    _price = value;
                }
            }
        }

        public string Name
        {
            get 
            { 
                return _name; 
            }
            set 
            { 
                if (value.Length >= 2 && !string.IsNullOrWhiteSpace(value) && char.IsUpper(value[0]))
                {    
                    _name= value;
                }
            }
        }


    }
}
