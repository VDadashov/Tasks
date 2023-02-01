using System;
using System.Globalization;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5 };
            AddValueToArray(ref num, 6);

            //for (int i = 0; i < num.Length; i++)
            //{
            //    Console.WriteLine(num[i]);
            //}

            foreach (int i in num)
            {
                Console.WriteLine(i);
            }

        }

        // Verilmiş int array-ə verilmiş int dəyəri əlavə edən metod.
        // Misalçün metodu çağırıb array elementimi və 5 dəyəri göndərsəm,
        // arrayim dəyişilməli və arrayin  içində əvəlki elementləri,
        // əlavə olaraq son indexində isə 5 elementi olmalıdır
        // və arrayin uzunluğu 1 vahid artmış olmalıdır.(metod geriye dəyər qaytarmır)

        static void AddValueToArray(ref int[] arr, int value)
        {
            int[] newArray = new int[arr.Length + 1];
            Array.Copy(arr, newArray, arr.Length);
            newArray[newArray.Length - 1] = value;
            arr = newArray;
        }
    }
}
