using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharpFunctionalWaltRitchser
{
    //My practice
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateOnly EnrollmentDate { get; set; }
        public decimal GPA { get; set; }
        public bool IsFullTime { get; set; }
        public List<string> Courses { get; set; }

        public Student(int id, string name, int age, DateOnly enrollmentDate, decimal gpa, bool isFullTime, List<string> courses)
        {
            Id = id;
            Name = name;
            Age = age;
            EnrollmentDate = enrollmentDate;
            GPA = gpa;
            IsFullTime = isFullTime;
            Courses = courses;
        }
    }
}
