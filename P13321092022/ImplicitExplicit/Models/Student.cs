using System;
using System.Collections.Generic;
using System.Text;

namespace ImplicitExplicit.Models
{
    class Student
    {
        public string Name;
        public string SurName;
        public double Grade;

        public static explicit operator Teacher(Student student)
        {
            return new Teacher
            {
                Name = student.Name,
                SurName = student.SurName,
                Grade = student.Grade
            };

            //return teacher;
        }
    }
}
