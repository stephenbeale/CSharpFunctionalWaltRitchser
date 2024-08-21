using CSharpFunctionalWaltRitchser;

using System.Collections.Immutable;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        var examples = new Examples();
        examples.DoWork();

        var students = examples.GetStudentsForSteve();
        students.ForEach(student =>
        {
            Console.WriteLine(student.Id);
            Console.WriteLine(student.Name);
            Console.WriteLine(student.Age);
            Console.WriteLine(student.EnrollmentDate);
            Console.WriteLine(student.GPA);
            Console.WriteLine(student.IsFullTime);
            Console.WriteLine(student.Courses);
        });
    }
}