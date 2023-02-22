using System;
using System.Collections.Generic;
using System.Text;

namespace _23._02._2023
{
    internal class Student
    {
        public string FullName;
        public string GroupNo;
        public List<Exam> Exams = new List<Exam>();



        public List<Exam> GetExamsByPointRange(int minPoint, int maxPoint)
        {
            List<Exam> wantedExams = new List<Exam>();

            foreach (Exam item in Exams)
            {
                if (item.Point >= minPoint && item.Point <= maxPoint)
                {
                    wantedExams.Add(item);
                }
            }
            return wantedExams;
        }

        public List<Exam> GetExamsByDateRange(DateTime fromDate, DateTime toDate)
        {
            List<Exam> wantedExams = new List<Exam>();

            foreach (var item in Exams)
            {
                if (item.Startat >= fromDate && item.Startat <= toDate)
                {
                    wantedExams.Add(item);
                }
            }
            return wantedExams;
        }

        public int GetAvgPoint()
        {
            int sum = 0;
            foreach (var item in Exams)
            {
                sum += item.Point;
            }
            return sum / Exams.Count;


        }
    }
}
