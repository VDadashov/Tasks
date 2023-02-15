using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace task2
{
    internal class Student
    {
        string _fullName;
        string _groupNo;
        public byte Age;

        public string FullName
        {
            get=>_fullName;

            set
            {
                if (CheckFullName(value))
                {
                    _fullName = value;
                }
            }
        }
        public string GroupNo
        {
            get=> _groupNo;

            set
            {
                if(CheckNo(value))
                {
                    _groupNo = value;
                }
            }
        }


        public static bool CheckNo(string no)
        {
            if (no == null) return false;

            if (no.Length != 4)
                return false;

            if (char.IsUpper(no[0]) && char.IsDigit(no[1]) && char.IsDigit(no[2]) && char.IsDigit(no[3]))
                return true;

            return false;
        }

        public static bool CheckFullName(string fullName) //Vusal Dadasov
        {
            if (fullName == null) 
                return false;

            if (fullName.StartsWith(' ') || fullName.EndsWith(' '))
                return false;

            var arr = fullName.Split(' ');

            if (arr.Length != 2)
            {
                return false;
            }


            return true;
            
            
        }
    }
}
