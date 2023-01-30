using System;

namespace task5
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
            var result = MaxOfDigit( numbers );
            Console.WriteLine($"Arraydeki en boyuk eded --> {result}");
        }

        // Verilmiş ədədlər siyahısındaki ən böyük ədədi qaytaran metod

        static int MaxOfDigit(int[] numbers)
        {
            int maxDigit = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]>maxDigit)
                {
                    maxDigit = numbers[i];
                }
            }
            return maxDigit;

        }


    }
}
