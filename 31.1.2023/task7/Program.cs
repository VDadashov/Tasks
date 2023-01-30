using System;

namespace task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir yazi daxil edin:");
            string inputStr = Console.ReadLine();
            var result = Reverse(inputStr);
            Console.WriteLine(result);
        }

        // Verilmiş yazını əks şəkildə qaytaran metod

        static string Reverse(string str)
        {
            string newStr = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                newStr += str[i];
            }

            return newStr;
        }
    }
}
