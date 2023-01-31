using System;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices.WindowsRuntime;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 12, -5, 45, 3, -11, 24 };

            int[] newArr = MakePositive(numbers);

            for (int i = 0; i < newArr.Length; i++)
            {
                if (newArr[i] != 0)
                {
                    Console.WriteLine(newArr[i]);
                }
                
            }

            

        }

        // Verilmiş ədədlər siyahısından yalnız müsbət ədədlərindən ibarət
        // yeni bir array düzəldib qaytaran metod

        static int[] MakePositive(int[] numbers)
        {
            int[] newArr = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]>0)
                {
                    newArr[i] = numbers[i];
                }
            }

            return newArr;

            

        }



    }
}
