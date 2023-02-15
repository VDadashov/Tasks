using System;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int num = 11;
            string str = "lellO";
            //Console.WriteLine(num.IsOdd());
            //Console.WriteLine(num.IsEven());
            //Console.WriteLine(str.IsContainsDigit());
            ////Console.WriteLine(str.ToCapitalize());
            //Console.WriteLine(str.IndexOf('f') );

            var arr = str.GetValueIndexes('l');

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
