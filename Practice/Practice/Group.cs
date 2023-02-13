using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    internal class Group
    {
        private string _no;
        private double _avgPoint;

        public string No
        {
            get
            {
                return _no;
            }
            set
            {
                if (CheckNumber(value))
                {
                    _no = value;
                }
            }
        }

        public bool CheckNumber(string no)
        {
            if (no != null && no.Length == 4 && char.IsUpper(no[0]) && char.IsDigit(no[1]) && char.IsDigit(no[2]) && char.IsDigit(no[3]))
            {
                return true;
            }
            return false;
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
    }
}
