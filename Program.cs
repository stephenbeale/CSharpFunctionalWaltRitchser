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
            Console.WriteLine($"{student.Id},{student.Name},{student.Age},{student.EnrollmentDate},{student.GPA},{student.IsFullTime}");
            Console.WriteLine("Courses: " + string.Join(", ", student.Courses));
            Console.WriteLine();
        } );
    }
}