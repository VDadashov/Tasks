using System;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = Num();
            int num2 = Num();   

            var result = SumOfNum(num1, num2);
            Console.WriteLine($"iki ededin cemi --> {result}");
        }

        // Verilmiş iki ədədi toplayıb qaytaran metod

        static int SumOfNum(int num1,int num2)
        {
            int sum = num1 + num2;

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
