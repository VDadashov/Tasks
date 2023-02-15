using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace task1
{
    internal static class ExtentionMethods
    {
        public static bool IsOdd(this int num)
        {
            if (num % 2 != 0) 
                return true;
            else return false;
        }

        public static bool IsEven(this int num)
        {
            if (num % 2 == 0)
                return true;
            else return false;
            
        }

        public static bool IsContainsDigit(this string str)
        {
            foreach (var ch in str)
            {
                if (char.IsDigit(ch))
                {
                    return true;
                }
            }
            return false;
        }

        public static string ToCapitalize(this string str)
        {
            string newStr = Char.ToUpper(str[0]) + str.Substring(1).ToLower();

            return newStr;
        }

        public static int[] GetValueIndexes(this string str,char wantedChar)
        {
            int[] arr = new int[0];

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == wantedChar)
                {
                    Array.Resize(ref arr, arr.Length + 1);
                    arr[arr.Length - 1] = i;    
                }
            }
            return arr;
        }
    }
}
