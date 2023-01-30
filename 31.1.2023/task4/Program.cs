using System;

namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array'in olcusunu daxil edin:");
            string countStr = Console.ReadLine();
            int count = Convert.ToInt32(countStr);

            int[] numbers = new int[count];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Arrayin {i + 1}'ci ededi daxil edin");
                string numStr = Console.ReadLine();
                int num = Convert.ToInt32(numStr);

                numbers[i] = num;
            }

            SumOfArray(numbers);

        }

        // Verilmiş ədədlər siyahısındaki ədədlərin cəmini console-a yazdıran metod

        static void SumOfArray(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine($"Arrayin ededlerin cemi --> {sum}");
        }
    }
}
