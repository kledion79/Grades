﻿using System;

namespace Grades
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;
            g1.Name = "Scott great book";
            Console.WriteLine(g2.Name);
            Console.ReadLine();
            /*
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine(stats.AverageGrade);
            Console.WriteLine(stats.HighestGrade);
            Console.WriteLine(stats.LowestGrade);
            Console.ReadLine();
            */

        }
    }
}