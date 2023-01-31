using System;

namespace classwork1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 12, 6, 9, 23, 64, 3 };

            var result = SumOfArray(numbers);

            Console.WriteLine($"Array'in musbet ededlerin cemi --> {result}");
        }

        static int SumOfArray(int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                

                if (array[i]>0)
                {
                    sum += array[i];
                }
            }

            return sum;
            
        }
    }
}
