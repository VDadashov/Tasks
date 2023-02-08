using System;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee employee = new Employee();

            //employee.Salary = 10;
            //employee.Salary = 450;

            //Console.WriteLine(employee.Salary);

            Console.Write("Engineer count: ");
            int count = Convert.ToInt32(Console.ReadLine());
            Engineer[] engineers = new Engineer[count];

            

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"\n{i+1},Engineer'i daxil edin");

                Console.WriteLine("\nFullName'i daxil edin:");
                string fuLllName = Console.ReadLine();

                Console.WriteLine("Salary'i daxil edin:");
                trySalary: int salary = Convert.ToInt32(Console.ReadLine());

                if (salary < 1000)
                {
                    Console.WriteLine("salary 1000'den aşağı ola bilmez");
                    goto trySalary;
                }

                Engineer engineer = new Engineer() { FullName = fuLllName, Salary = salary };


                Console.WriteLine("-----------------");

                
                engineers[i] = engineer;
            }

            double sum = 0;

            for (int i = 0; i < engineers.Length; i++)
            {
                sum += engineers[i].Salary;
            }

            var result = sum / engineers.Length;


            Console.WriteLine($"Maash ortalamasi: {result}");
            
        }
    }
}
