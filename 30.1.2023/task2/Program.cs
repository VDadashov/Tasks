using System;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Verilmiş qiymət dəyəri 64-dən böyük olarasa console-da "məzun oldunuz",
            //  əks halda "məzun olmadınız" yazdırsan proqram. 
            // Qiymət dəyərini console-dan qəbul edin (Readline ilə).
            // Qiymət dəyəri 0-100 aralığında olmalıdır,
            // 0-dan kiçin və ya 100-dən böyük dəyər daxil edələrsə yenidən daxil edilməsi istənilsin proqram tərəfindən.

            Console.WriteLine("Qiymeti daxil edin -->");
            string input = Console.ReadLine();
            int point = Convert.ToInt32(input);

            while (point<=0 || point>=100)
            {
                Console.WriteLine("Qiymet deyeri 0-100 aralığında olmalıdır");
                input = Console.ReadLine();
                point = Convert.ToInt32(input);
            }

            if (point > 64)
            {
                Console.WriteLine("mezun oldunuz");
            }
            else
            {
                Console.WriteLine("mezun olmadiniz");
            }
        }
    }
}
