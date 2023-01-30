using System;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = Num();
            int num2 = Num();

            SumOfNum(num1, num2);
        }

        // Verilmiş iki ədədi toplayıb console-a yazdıran metod

        static void SumOfNum(int num1,int num2)
        {
            Console.WriteLine($"iki ededin cemi --> {num1+num2}");
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
