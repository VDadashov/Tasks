using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    internal class Group
    {
        string _no;
        double _avgPoint;

        public string No
        {
            get { return _no; }
            set { _no = value; }
        }
        public double AvgPoint
        {
            get
            {
                return _avgPoint;
            }
            set 
            {
                if (value>=0 && value <= 100)
                {
                    _avgPoint = value;
                } 
            }
        }

    }
}
