using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

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
                Console.WriteLine("\n1. Butun telebelere bax");
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
                        for (int i = 0; i < Students.Length; i++)
                        {
                            Console.WriteLine(Students[i]);
                        }
                        break;

                    case "2":

                        Console.WriteLine("\nFullName'i daxil edin:");
                        TryFullname: string fullName = Console.ReadLine();
                        
                        if (fullName.Length < 3)
                        {
                            Console.WriteLine("FullName 2den uzun olmalidi");
                            goto TryFullname;
                        }

                        StartLetterUpper(ref fullName);

                        Array.Resize(ref Students, Students.Length + 1);
                        Students[Students.Length - 1] = fullName;
                        break;

                    case "3":
                        Console.WriteLine("Axtaris deyeri daxil et:");
                        string text = Console.ReadLine();
                        bool isValue = false;

                        for (int i = 0; i < Students.Length; i++)
                        {
                            if (Students[i].Contains(text))
                            {
                                Console.WriteLine(Students[i]);
                                isValue = true;
                            }
                        }
                        if (isValue == false)
                        {
                            Console.WriteLine("Axtaris deyerin'de fullName yoxdur");
                        }

                        break;

                    case "4":

                        for (int i = 0; i < Students.Length; i++)
                        {
                            int SpaceIndex = Students[i].IndexOf(' ');
                            Console.WriteLine(Students[i].Substring(0,SpaceIndex ));
                        }

                        break;

                    case "5":
                        Console.WriteLine("\nTelebenin fullName daxil edin:");
                        string searchPerson = Console.ReadLine();

                        StartLetterUpper(ref searchPerson);
                        bool isExist = false;

                        for (int i = 0; i < Students.Length; i++)
                        {
                            if (Students[i] == searchPerson)
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
                        Console.WriteLine("Menu'dan cixilir...");
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
    }

    
   
}
