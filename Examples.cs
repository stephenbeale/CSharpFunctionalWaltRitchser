using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;


namespace CSharpFunctionalWaltRitchser
{
    public class Examples
    {
        //I/O is a side effect
        //Create separate functions for all I/O work

        //example: OpenFile, UpdateFile
        //Use pure function to perform computations on the file contents.
        private const string RobotFileName = "RobotNames.xml";
        private const string StudentFileName = "Students.xml";
       public void DoWork()
        {
            var rootNames = GetRobots();
            Student student = new Student(id: 1, name: "me", age: 23, enrollmentDate: new DateOnly(day: 01, month:01, year:2020), gpa: 2.3, isFullTime: true, courses: new List<string> { "Maths", "Computer Science" });

        }

        public ImmutableList<Student> GetStudentsForSteve()
        {
            try
            {
                var xmlDetails = XDocument.Load(StudentFileName);
                //Root elementS should point to all in list, not first entry of sub-list
                var students = xmlDetails.Root.Elements("Student").
                    Select(x => new Student(
                        //String name here must match XML exactly
                        id: (int)x.Element("ID"),
                        name: x.Element("Name").Value,
                        age: (int)x.Element("Age"),
                        enrollmentDate: DateOnly.Parse(x.Element("EnrollmentDate").Value),
                        gpa: double.Parse(x.Element("GPA").Value),
                        isFullTime: bool.Parse(x.Element("IsFullTime").Value),
                        courses: x.Element("Courses") != null ?
                        x.Element("Courses")
                            .Elements("Course")
                            .Select(c => c.Value)
                            .ToList() : new List<string>()
                        )).ToArray();

                return ImmutableList.Create(students);
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message}");
                return ImmutableList<Student>.Empty;
            }
        }

        public ImmutableList<Robot> GetRobots()
        {
            try
            {
                //Load function to load up contents (into memory??)
                var xmlDoc = XDocument.Load(RobotFileName);
                //Use Linq to retrieve details from the file contents
                //Select ALL root elements, instantiate new Robot from each of those elements, then to an array to retrun as list
                //ToArray because it needs to be returned as immutable - array is immutable list compatible
                var robots = xmlDoc.Root.Elements("Robot")
                    .Select(x => new Robot
                    {
                        RobotName = x.Element("RobotName").Value,
                        TeamName = x.Element("TeamName").Value,
                        Weight = (int)x.Element("Weight")
                    }).ToArray();

                return ImmutableList.Create(robots);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
