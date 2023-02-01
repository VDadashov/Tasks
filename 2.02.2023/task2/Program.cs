using System;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Verilmiş yazıda reqem olub olmadığını tapan metod.");
            Console.Write("Text'i daxil edin --> ");
            string text = Console.ReadLine();
            Console.WriteLine(ContainsNumber(text));

        }

        // Verilmiş yazıda rəqəm olub olmadığını tapan metod.
        // Göndərilən yazıda rəqəm varsa true yoxdursa false qaytarır.

        static bool ContainsNumber(string text)
        {
            foreach (char c in text)
            {
                if (char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
        }



    }
}
