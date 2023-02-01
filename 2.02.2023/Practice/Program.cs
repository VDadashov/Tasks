using System;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num1 = { 11, 2, 35, 43, 5, 6 };
            int[] num2 = { 12, 153, 114, 15, };

            Array.Sort(num1);
            Array.Sort(num2);

            for (int i = 0; i < num1.Length; i++)
            {
                Console.WriteLine(num1[i]);
            }

            Console.WriteLine("Get Value:\t{0}", num1.GetValue(2));
            Console.WriteLine("Get Value:\t{0}", num2.GetValue(3));

            Array.Copy(num1, num2, 2);

            for (int i = 0; i < num2.Length; i++)
            {
                Console.WriteLine(num2[i]);
            }


            string name = "     Hello World      ";
            string newName = name.Trim();
            Console.WriteLine(newName);

            string name1 = "    Hello World      ";
            int name1Count = name1.Length;

            Console.WriteLine(name1Count);

            string metin1 = "wwww.programlamadersleri.com";
            string yenimetin1 = metin1.Remove(0, 2);
            Console.Write(yenimetin1);
            Console.Read();

            string metin = "wwww.programlamadersleri.com";
            string yenimetin = metin.Substring(5, 19);
            Console.Write(yenimetin);
            Console.Read();

            //string metin = "wwww.programlamadersleri.com";
            //string yenimetin = metin.Remove(0, metin.Length / 2);
            //Console.Write(yenimetin);
            //Console.Read();

            //string metin2 = "programlamadersleri";
            //for (int i = 0; i < metin2.Length; i++)
            //{
            //    string yeni = metin2.Substring(i, 1);
            //    Console.WriteLine(yeni);
            //    Console.ReadLine();
            //}

            Console.WriteLine("Text'i daxil edin");
            string text;
            int count = 1;
            text = Console.ReadLine();
            string newText = text.Trim();

            for (int i = 1; i < newText.Length; i++)
            {
                if (newText.Substring(i, 1) == " ")
                    count += 1;
            }
            Console.WriteLine("Bu metinde {0} kelime kullanılmıştır.", count);
            Console.ReadLine();




        }
    }
}
