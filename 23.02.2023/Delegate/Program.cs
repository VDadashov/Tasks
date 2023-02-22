using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Delegate
{
    internal class Programs
    {
        static void Main(string[] args)
        {
            List<Exam> exams = new List<Exam>();

            exams.Add(new Exam { Subject = "Math", StartedAt = DateTime.Parse("2023-02-21 10:00:00"), FinishedAt = DateTime.Parse("2023-02-21 11:30:00") });
            exams.Add(new Exam { Subject = "Science", StartedAt = DateTime.Parse("2023-02-22 08:30:00"), FinishedAt = DateTime.Parse("2023-02-22 10:00:00") });
            exams.Add(new Exam { Subject = "History", StartedAt = DateTime.Parse("2023-02-23 13:00:00"), FinishedAt = DateTime.Parse("2023-02-23 15:00:00") });
            exams.Add(new Exam { Subject = "English", StartedAt = DateTime.Parse("2023-02-24 11:00:00"), FinishedAt = DateTime.Parse("2023-02-24 13:00:00") });
            exams.Add(new Exam { Subject = "Geography", StartedAt = DateTime.Parse("2023-02-25 09:00:00"), FinishedAt = DateTime.Parse("2023-02-25 10:30:00") });


            Predicate<Exam> lessThanTwoHours = (exam) => (exam.FinishedAt - exam.StartedAt).TotalHours < 2;
            Predicate<Exam> inLast24Hours = (exam) => exam.StartedAt > DateTime.Now && exam.StartedAt < DateTime.Now.AddDays(1);
            Predicate<Exam> today = (exam) => exam.StartedAt > DateTime.Now && exam.StartedAt < DateTime.Now.AddDays(1);
            Predicate<Exam> lastYear = (exam) => exam.FinishedAt.Year == DateTime.Now.Year - 1;

            Console.WriteLine("===========lessThanTwoHours===========");

            int count = exams.FindAll(lessThanTwoHours).Count;
            Console.WriteLine($"2 saatdan az çekmish imtahanların sayı: {count}");

            Console.WriteLine("==========last24hours==========");

            List<Exam> last24Hours = exams.FindAll(inLast24Hours);
            foreach (Exam exam in last24Hours)
            {
                Console.WriteLine($"Subject: {exam.Subject}, StartedAt: {exam.StartedAt}");
            }

            Console.WriteLine("=============firstExam============");

            Exam firstExam = exams.Find(today);
            if (firstExam != null)
            {
                Console.WriteLine($"Subject: {firstExam.Subject}, StartedAt: {firstExam.StartedAt}");
            }

            Console.WriteLine("===========lastYear============");

            bool programmingExam = exams.Exists(exam => exam.Subject == "Programming" && lastYear(exam));
            Console.WriteLine($"Keçen il keçirilen imtahanlar arasında Proqramlashdırma imtahanı olubmu? {programmingExam}");
        }
    }
}
