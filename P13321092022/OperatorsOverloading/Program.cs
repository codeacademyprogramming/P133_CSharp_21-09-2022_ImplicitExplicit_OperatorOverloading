using OperatorsOverloading.Models;
using System;

namespace OperatorsOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 15;

            Student student1 = new Student { Name = "Aqil", SurName = "Soltanli", Grade = 55 };
            Student student2 = new Student { Name = "Emin", SurName = "Suleymanov", Grade = 35 };

            string totalGrade = student1 + student2;

            Console.WriteLine(totalGrade);

            Console.WriteLine(student1 < student2);
        }
    }
}
