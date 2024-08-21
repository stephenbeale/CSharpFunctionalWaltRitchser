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
        private const string StudentFileName = "Students.xml"
       public void DoWork()
        {
            var rootNames = GetRobots();
        }

        public ImmutableList<Robot> GetStudentsForSteves()
        {
            try
            {
                var xmlDetails = XDocument.Load(StudentFileName);
                var students = xmlDetails.Root.Elements("Student").
                    Select(x => new Student
                    {
                        Id = (int)x.Element("Id"),
                        Name = x.Element("Name").Value,
                        Age = (int)x.Element("Age"),
                        EnrollmentDate = (DateOnly)DateOnly.TryParse(x.Element("EnrollmentDate"),
                        GPA = (decimal)x.Element("GPA"),
                        IsFullTime = (bool)x.Element("IsFullTime"),
                        Courses = x.Element("course").Value)
                    }).ToArray();

                return students;
            }
            catch (Exception e)
            {

                Console.WriteLine($"{e.Message}"); ;
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
