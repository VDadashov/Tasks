using System;

namespace task3
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
                Console.WriteLine($"Arrayin {i+1}'ci ededi daxil edin");
                string numStr = Console.ReadLine();
                int num = Convert.ToInt32(numStr);

                numbers[i] = num;
            }

            var result = SumOfArray(numbers);
            Console.WriteLine($"Arrayin ededlerin cemi --> {result}");

        }

        // Verilmiş ədədlər siyahısındaki ədədlərini cəmini qaytaran metod

        static int SumOfArray(int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }

            return sum;
        }
    }
}
