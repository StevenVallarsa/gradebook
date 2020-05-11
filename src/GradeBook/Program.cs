using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {

        static void Main(string[] args)
        {
            var numList = new List<double>() { 1.1, 2, 2, 3.3 };

            double result = 0;

            foreach (var num in numList)
            {
                result += num;
            }

            Console.WriteLine($"The result is {result / numList.Count:N1}");
        }

    }

    public class Book
    {

    }
}
