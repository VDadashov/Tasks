using System;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Verilmiş ədədlər siyahısındaki ən böyük ədədi tapan proqram

            int[] numbers = { 1, -5, 8, 9, 11, -12, 3 };

            int maxNum = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]>maxNum)
                {
                    maxNum = numbers[i];
                }
            }
            Console.WriteLine("Siyahida en boyuk eded --> "+maxNum);
        }
    }
}
