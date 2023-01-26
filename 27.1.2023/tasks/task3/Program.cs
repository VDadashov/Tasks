using System;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Verilmiş ədədlər siyahısında mənfi ədəd olub olmadığını tapan proqram

            int[] numbers = { 1, 5, 8, 9, 11, 12, 3 };

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]<0)
                {
                    Console.WriteLine("Siyahida menfi eded var --> "+ numbers[i]);
                    break;
                }
            }
            Console.WriteLine("Siyahida menfi eded yoxdur");
        }
    }
}
