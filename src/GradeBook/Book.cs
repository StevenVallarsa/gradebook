using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook
{
    class Book
    {
        List<double> grades;

        public Book()
        {
            grades = new List<double>();
        }

        public void AddGrade(double grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                grades.Add(grade);
            }
            else
            {
                Console.WriteLine("That grade is out of range. Try again.");
            }
        }

        public void ShowStats()
        {
            var total = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;

            foreach(var number in grades)
            {
                highGrade = Math.Max(number, highGrade);
                lowGrade = Math.Min(number, lowGrade);
                total += number;
            }

            Console.WriteLine($"The lowest grade is {lowGrade}.");
            Console.WriteLine($"The highest grade is {highGrade}.");
            Console.WriteLine($"The average grade is {total/grades.Count}.");

        }

    }
}
