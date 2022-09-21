using ImplicitExplicit.Models;
using System;

namespace ImplicitExplicit
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student
            {
                Name = "Semed",
                SurName = "Aliyev",
                Grade = 60
            };

            Teacher teacher = (Teacher)student;
            teacher.Profession = "Programming";
            teacher.Experiance = "50 il";

            //Console.WriteLine($"{teacher.Name} {teacher.SurName} {teacher.Grade}");

            Student student1 = teacher;

            Manat manat = new Manat { AZN = 200 };
            Console.WriteLine($"AZN: {manat.AZN}");
            Dollar dollar = (Dollar)manat;
            Console.WriteLine($"USD: {dollar.USD}");
            manat = (Manat)dollar;
            Console.WriteLine($"AZN: {manat.AZN}");

            //byte a = 120;
            //double b = a;

            //a = (byte)b;
        }
    }
}
