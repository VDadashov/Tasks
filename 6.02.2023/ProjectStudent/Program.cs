using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace ProjectStudent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Students = { "Vusal Dadashov","Murad Quliyev","Fexri Ehmedov","Emin Suleymanov" };

            string option;

            do
            {
                Console.WriteLine("\n1.Butun telebelere bax");
                Console.WriteLine("2.Yeni telebe elave et");
                Console.WriteLine("3.Telebeler uzre axtaris et");
                Console.WriteLine("4.Telebelerin adlarina bax");
                Console.WriteLine("5.Siyahida adin olub olmadigina bax");
                Console.WriteLine("0. Menudan cix");

                Console.Write("\nSecimi daxil edin: ");
                TryOption: option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        AllStudentsShow(Students);
                        break;

                    case "2":

                        Console.WriteLine("\nFullName'i daxil edin:");
                        TryFullname: string fullName = Console.ReadLine();
                        
                        if (fullName.Length < 3)
                        {
                            Console.WriteLine("FullName minumum 3 uzunluqda olmalidir:");
                            goto TryFullname;
                        }

                        StartLetterUpper(ref fullName);

                        Array.Resize(ref Students, Students.Length + 1);
                        Students[Students.Length - 1] = fullName;
                        break;

                    case "3":
                        Console.WriteLine("Axtaris deyeri daxil et:");
                        string searchValue = Console.ReadLine();                      
                        SearchForStudents(Students, searchValue);
                        break;

                    case "4":
                        ViewStudentsName(Students);
                        break;

                    case "5":
                        Console.WriteLine("\nTelebenin fullName daxil edin:");
                        string searchStudents = Console.ReadLine();

                        StartLetterUpper(ref searchStudents);
                        bool isExist = false;

                        for (int i = 0; i < Students.Length; i++)
                        {
                            if (Students[i] == searchStudents)
                            {
                                isExist = true;
                            }
                        }
                        if (isExist == true)
                        {
                            Console.WriteLine("\nvar...");
                        }
                        else
                        {
                            Console.WriteLine("\nyoxdur...");
                        }

                        break;

                    case "0":
                        Console.WriteLine("Menu'dan cixildi...");
                        break;

                    default:
                        Console.WriteLine("\nSecim sehvdir,yeniden daxil edin:");
                        goto TryOption;
                }


            } while (option != "0");
        }

        static void StartLetterUpper(ref string fullName) // FullName'de first ve last namelerini upper eden metod
        {
            string newStr = "";
            var arr = fullName.Split(' ');

            while (arr.Length < 2) // FirstName ve LastName oldugu ucun Length 2den az ola bilmez...
            {
                Console.WriteLine("\nFullName yanlishdir , yeniden daxil edin:");
                fullName = Console.ReadLine();
                arr = fullName.Split(" ");
            }

            for (int i = 0; i < arr.Length; i++)
            {
                newStr += arr[i].Substring(0, 1).ToUpper() + arr[i].Substring(1).ToLower();
                newStr += ' ';
            }

            newStr = newStr.TrimEnd(); // Sonda bir WhiteSpace oldugu ucun TrimEnd

            fullName= newStr;
        }

        static void AllStudentsShow(string[] students)
        {
            Console.WriteLine("\nTeleberin FullName'ler i:");
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i]);
            }
        }

        static void SearchForStudents(string[] students, string input) // Axtaris deyerini yoxlayan metod
        {
            bool isValue = false;

            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Contains(input))
                {
                    Console.WriteLine(students[i]);
                    isValue = true;
                }
            }
            if (isValue == false)
            {
                Console.WriteLine("Axtaris deyerin'de fullName yoxdur");
            }
        }

        static void ViewStudentsName(string[] students)
        {
            Console.WriteLine("\nTeleberin adlari:");
            for (int i = 0; i < students.Length; i++)
            {
                int SpaceIndex = students[i].IndexOf(' ');
                Console.WriteLine(students[i].Substring(0, SpaceIndex));
            }
        }
    }
   
}
