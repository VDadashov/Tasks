using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiers_2
{
    internal class Group
    {
        string _no;
        double _avgPoint;

        public string No
        {
            get
            {
                return _no;
            }
            set
            {
                if (CheckBool(value))
                {
                    _no = value;
                }
            }
        }

        public double AvgPoint
        {
            get
            {
                return _avgPoint;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _avgPoint = value;
                }
            }
        }

        public bool CheckBool(string value)
        {
            if (value.Length == 3 && char.IsUpper(value[0]) && char.IsDigit(value[1]) && char.IsDigit(value[2]) && char.IsDigit(value[3]))
            {
                return true;
            }
            return false;
        }
    }
}
