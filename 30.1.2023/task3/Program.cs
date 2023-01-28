using System;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Verilmiş ədədlər siyahısındaki 21-ə bölenən ədədlərin ədədi ortasını tapan proqram

            int[] numbers = { 12, 21, 78, 42, 102, 63, 84 };

            double sum = 0;
            double count = 0;

            double EdediOrta;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]%21 == 0)
                {
                    sum += numbers[i];
                    count++;
                }
            }

            if (count == 0)
            {
                Console.WriteLine("siyahida 21'e bolunen eded tapilmadi");
            }
            else
            {
                EdediOrta = sum / count;
                Console.WriteLine(EdediOrta);
            }

            
        }
    }
}
