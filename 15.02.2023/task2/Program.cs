using System;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string text = Console.ReadLine();
            //text = text.Trim();
            //var arr = text.Split(' ');
            //Console.WriteLine(arr.Length);
            #region Task1
            Student student = new Student();
            student.FullName = "VusalDadashov";
            student.FullName = "Vusal Dadashov";
            student.FullName = "   Vusal Dadashov";
            student.FullName = "Vusal  Dadashov   ";
            student.FullName = "   Vusal  Dadashov   ";
            Console.WriteLine(student.FullName);
            #endregion

            string no;
            do
            {
                Console.Write("GroupNo: ");
                no = Console.ReadLine();
            } while (!Student.CheckNo(no));


            string fullName;
            do
            {
                Console.Write("FullName: ");
                fullName = Console.ReadLine();
            } while (!Student.CheckFullName(fullName));

            

            Student std1 = new Student { Age = 10, GroupNo = no, FullName = fullName };

            Console.WriteLine(std1.FullName);




        }
    }
}
