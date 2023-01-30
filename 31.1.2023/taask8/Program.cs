using System;

namespace taask8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = Num();

            int result = SumOfDigits(num1);

            Console.WriteLine($"Verilmis ededin reqemleri cemi --> {result}");
        }

        // Verilmiş ədədin rəqəmləri cəmini qaytaran metod

        static int SumOfDigits(int n)
        {
            int sum = 0;

            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }

            return sum;
        }

        static int Num()
        {
            Console.WriteLine("ededi daxil edin");
            string numStr = Console.ReadLine();
            int num = Convert.ToInt32(numStr);

            return num;
        }
    }
}
