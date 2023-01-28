using System;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Verilmiş ədədin rəqəmləri cəmini tapan proqram

            Console.WriteLine("Ededi daxil edin");
            string input = Console.ReadLine();
            int num  = Convert.ToInt32(input);

            int sum = 0;

            while (num != 0)
            {
                int r = num % 10;
                num = num / 10;
                sum = sum + r;
            }
            Console.WriteLine(sum);

        }
    }
}
