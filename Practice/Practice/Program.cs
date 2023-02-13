using System;
using System.Text.RegularExpressions;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Course course = new Course();
            Group group = new Group();

            string secin;

            do
            {
                Console.WriteLine("\n1.Qrup elave etin:");
                Console.WriteLine("2.Butun qruplara baxin:");
                Console.WriteLine("3.Verilmis point araligindaki qruplara baxin:");
                Console.WriteLine("4.Verilmis nomreli qrupa baxin:");
                Console.WriteLine("5.Verilmis qruplar uzre axtaris edin:");
                Console.WriteLine("0.Menudan cixin(");

                Console.WriteLine("\nSeciminizi daxil edin:");

                secin = Console.ReadLine();

                switch (secin)
                {
                    case "1":
                        Console.WriteLine("\nElave edeceyiniz qrupun daxil edilmesi)");

                        string ch;
                        do
                        {
                            string no;
                            do
                            {
                                Console.WriteLine("\nElave edeceyiniz qrupun nomresini daxil edin:");
                                no = Console.ReadLine();
                            }
                            while (group.CheckNumber(no)) ;

                            string average;
                            double avgpoint;

                            do
                            {
                                Console.WriteLine("\nElave edeceyiniz qrupun orta balini daxil edin:");
                                average = Console.ReadLine();

                            }
                            while (!double.TryParse(average, out avgpoint) || avgpoint >= 100);

                            Group grp = new Group()
                            {
                                No = no,
                                AvgPoint = avgpoint
                            };

                            course.AddGroup(grp);

                            do
                            {
                                Console.WriteLine("\nQrup elave etmek isteyirsinizmi? y/n");

                                ch = Console.ReadLine();
                            }
                            while (ch != "n" && ch != "y");


                        }
                        while (ch == "y");

                        break;
                    case "2":
                        Console.WriteLine("\nGruplar:");
                        for (int i = 0; i < course.Groups.Length; i++)
                        {
                            Console.WriteLine(course.Groups[i].No);
                            Console.WriteLine(course.Groups[i].AvgPoint);
                        }

                        break;
                    case "3":
                        Console.WriteLine("\nVerilmis point araligindaki qruplar:");
                        string min;
                        int minPoint;

                        do
                        {
                            min = Console.ReadLine();
                        }
                        while (!int.TryParse(min, out minPoint));

                        string max;
                        int maxPoint;

                        do
                        {
                            max = Console.ReadLine();
                        }
                        while (!int.TryParse(max, out maxPoint));

                        course.GetGroupByPointRange(minPoint, maxPoint);
                        break;
                    case "4":
                        Console.WriteLine("\nAxtardiginiz qrupu daxil edin:");

                        string noo = Console.ReadLine();

                        if (noo == null)
                        {
                            Console.WriteLine($"{noo}-nomreli qrup yoxdur!");
                        }
                        else
                        {
                            course.GetGroupByNo(noo);
                        }

                        break;
                    case "5":
                        Console.WriteLine("\nYazini daxil edin:");

                        string str = Console.ReadLine();

                        course.Search(str);

                        break;
                    case "0":
                        Console.WriteLine("\nMenudan cixin(");
                        break;
                    default:
                        Console.WriteLine("\nDaxil etdiyiniz secim tapilmamaqdadir!");
                        break;
                }
            }
            while (secin != "0");

        }
    }
}
