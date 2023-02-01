using System;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Verilmiş yazıdaki sözlərin sayanı tapan metod.");
            Console.WriteLine("Text'i daxil edin");
            string text = Console.ReadLine();
            Console.WriteLine(CountWords(text));
        }

        // Verilmiş yazıdaki sözlərin sayanı tapan metod.
        // Boşluqla bir birindən ayrılmış bütün ifadələri söz kimi qəbul edin.
        // Və hər söz arasında bir boşluq varmış kimi hesab edin.

        static int CountWords(string text)
        {
            int wordCount = 0;
            bool wordStarted = false;
            foreach (char c in text)
            {
                if (char.IsWhiteSpace(c))
                {
                    wordStarted = false;
                }
                else if (!wordStarted)
                {
                    wordStarted = true;
                    wordCount++;
                }
            }
            return wordCount;
        }
    }
}
