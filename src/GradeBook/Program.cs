using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {

        static void Main(string[] args)
        {

            var book = new Book();
            book.AddGrade(56.1);
            book.AddGrade(99.0);
            book.AddGrade(78.9);
            book.AddGrade(36.1);
            book.AddGrade(72.9);

            book.ShowStats();

        }

    }

    
}
