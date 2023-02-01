using System;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RemoveStarSpace("  Hello World"));
        }

        // Verilmiş yazının əvvəlindəki boşluqları silib qaytaran metod

        // "  Hello World"

 

        static string RemoveStarSpace(string text)
        {
            string newStr = "";
            int index = 0;

            for (int i = 0; i < text.Length; i++)
            {
                
                if (text[i] != ' ')
                {
                    index = i;
                    break;
                }

            }

            for (int j = index; j < text.Length; j++)
            {
                newStr += text[j];
            }
            return newStr;
        }

        
    }
}
