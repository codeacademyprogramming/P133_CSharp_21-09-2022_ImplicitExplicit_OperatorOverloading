using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorsOverloading.Models
{
    class Student
    {
        public string Name;
        public string SurName;
        public double Grade;

        public static string operator +(Student first,Student second)
        {
            return first.Name+" " + second.Grade;
        }

        public static string operator -(Student first, Student second)
        {
            return first.Name + " " + second.Grade;
        }

        public static bool operator >(Student first, Student second)
        {
            return first.Grade > second.Grade;
        }

        public static bool operator <(Student first, Student second)
        {
            return first.Grade < second.Grade;
        }

        public static bool operator ==(Student first, Student second)
        {
            return first.Grade > second.Grade;
        }

        public static bool operator !=(Student first, Student second)
        {
            return first.Grade < second.Grade;
        }
    }
}
