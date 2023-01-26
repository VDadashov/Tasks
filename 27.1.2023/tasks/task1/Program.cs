using System;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilmiş 3 ədədən ən böyüyünü tapan proqram

            Console.WriteLine("num1'i daxil edin -->");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("num2'i daxil edin -->");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("num3'i daxil edin -->");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("1'ci eded en boyukdur.");
                }
                else
                {
                    Console.Write("3'cu eded en boyukdur.");
                }
            }
            else if (num2 > num3)
                Console.Write("2'ci eded en boyukdur.");
            else
                Console.Write("3'cu eded en boyukdur.");


        }
    }
}
