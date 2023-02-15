using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    internal class Drink:Product
    {
        double _alcoholPercent;

        public double AlcoholPercent
        {
            get => _alcoholPercent;
            set
            {
                if (value <= 40)
                {
                    _alcoholPercent = value;
                }
            }
        }
    }


}
