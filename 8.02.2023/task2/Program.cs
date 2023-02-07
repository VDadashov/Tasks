using System;
using System.Globalization;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime();
            Console.WriteLine("Tarixi daxil edin:");
            string dateStr = Console.ReadLine();
            date = Convert.ToDateTime(dateStr);
            Console.WriteLine(date);

            Console.WriteLine("Tarix'e elave etmek istediyiniz ili daxil edin:");
            int year = Convert.ToInt32(Console.ReadLine());
            date = date.AddYears(year);

            Console.WriteLine(date.ToString("dd-MM-yyyy"));



        }
    }
}
