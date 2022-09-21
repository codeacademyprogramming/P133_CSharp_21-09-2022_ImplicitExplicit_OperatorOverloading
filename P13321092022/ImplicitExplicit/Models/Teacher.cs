using System;
using System.Collections.Generic;
using System.Text;

namespace ImplicitExplicit.Models
{
    class Teacher
    {
        public string Name;
        public string SurName;
        public double Grade;

        public string Experiance;
        public string Profession;

        public static implicit operator Student(Teacher teacher)
        {
            Student student = new Student
            {
                Name = teacher.Name,
                SurName = teacher.SurName,
                Grade = teacher.Grade
            };

            return student;
        }
    }
}
