using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    internal class Human
    {
        public string Name;
        protected int _age;


        public virtual int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value>=0 && value <= 150)
                {
                    _age = value;
                }
                
            }
        }
    }
}
