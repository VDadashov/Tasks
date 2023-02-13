using System;
using System.Net.WebSockets;
using System.Runtime.InteropServices;

namespace AccessModifiers_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Course course = new Course();

            string option;
            do 
            {
                Console.WriteLine("\n1. Qrup elave et:");
                Console.WriteLine("2. Butun qruplara bax:");
                Console.WriteLine("3. Verilmis point aralingindaki qruplara bax:");
                Console.WriteLine("4. Verilmis nomreli qrupa bax:");
                Console.WriteLine("5. Verilmis qruplar uzre axtaris et:");
                Console.WriteLine("0. Menudan cix:\n");

                Console.Write("Secim'i daxil edin: ");
                tryOption: option= Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.Write("\nElave etmek istediyiniz qrup sayi: ");
                        int count = Convert.ToInt32(Console.ReadLine());

                        for (int i = 0; i < count; i++)
                        {
                            Console.WriteLine($"{i + 1}.Qrup");

                            Console.Write("No: ");
                            string no = Console.ReadLine();

                            Console.Write("AvgPoint: ");
                            double avgPoint = Convert.ToDouble(Console.ReadLine());

                            course.AddGroup(new Group { No= no , AvgPoint = avgPoint });

                            Console.WriteLine($"{i + 1}.Qrup elave edildi");
                            Console.WriteLine("----------");
                        }

                        break;

                    case "2":
                        Group[] arr = course.Groups;

                        for (int i = 0; i < arr.Length; i++)
                        {
                            Console.WriteLine($"{i + 1}.Qrup");
                            Console.WriteLine($"No: {arr[i].No}");
                            Console.WriteLine($"AvgPoint: {arr[i].AvgPoint}");
                            Console.WriteLine("----------");
                        }
                        break; 

                    case "3":
                        Console.Write("MinPoint:");
                        int min = Convert.ToInt32(Console.ReadLine());

                        Console.Write("MaxPoint:");
                        int max = Convert.ToInt32(Console.ReadLine());

                        Group[] arr1 = course.GetGroupsByPointRange( min, max );

                        Console.WriteLine();
                        for (int i = 0; i < arr1.Length; i++)
                        {
                            Console.WriteLine($"{i + 1}.Qrup");
                            Console.WriteLine($"No: {arr1[i].No}");
                            Console.WriteLine($"AvgPoint: {arr1[i].AvgPoint}");
                            Console.WriteLine("----------");
                        }
                        break;

                    case "4":
                        Console.WriteLine("Axtardiginiz nomre'ni daxil edin:");
                        string no_ = Console.ReadLine();

                        Group gp = course.GetGroupByNo( no_ );

                        if (gp == null)
                        {
                            Console.WriteLine("Bele qrup yoxdur...");
                        }
                        else
                        {
                            Console.WriteLine($"AvgPoint: {gp.AvgPoint}");
                        }
                        
                        break;

                    case "5":
                        Console.WriteLine("Axtarish deyeri:");
                        string search = Console.ReadLine();

                        Group[] gp1 = course.Search( search );

                        for (int i = 0; i < gp1.Length; i++)
                        {
                            Console.WriteLine($"{i + 1}.Qrup");
                            Console.WriteLine($"No: {gp1[i].No}");
                            Console.WriteLine($"AvgPoint: {gp1[i].AvgPoint}");
                            Console.WriteLine("----------");
                        }
                        break;

                    case "0":
                        break;

                    default:
                        Console.WriteLine("Secim yanlishdir,yeniden cehd edin:");
                        goto tryOption;
                }
            } 
            while (option != "0"); 
        }

    }
}
