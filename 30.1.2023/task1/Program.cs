using System;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Verilmiş ədədin rəqəmləri cəmini tapan proqram
            // N = 234

            Console.WriteLine("Ededi daxil edin");
            string input = Console.ReadLine();
            int N  = Convert.ToInt32(input);

            int sum = 0;

            while (N > 0)
            {
                int index = N % 10;
                sum += index;
                N /= 10;
            }
            Console.WriteLine(sum);

        }
    }
}
