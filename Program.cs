using System;
using System.Collections.Generic;
using System.IO;

namespace _433___Student_Registration
{

    class Program
    {
        static List<student> studentList = new List<student>();
        static List<course> courseList = new List<course>();
        static List<registration> registrationList = new List<registration>();

        FileStream importStream;
        FileStream exportStream;

        static void Main(string[] args)
        {



            string command = "start";

            Console.WriteLine("Welcome to the registration software");


            while (command.Equals("exit") == false)
            {
                optionsL1();

                command = Console.ReadLine();

                switch (command.ToLower())
                {
                    case "import":
                        
                        break;

                    case "export":

                        break;

                    case "add":

                        break;

                    case "remove":

                        break;

                    case "display":

                        break;
                }
            }

        }

        public class student
        {
            public enum schoolYear
            {
                Freshman,
                Sophomore,
                Junior,
                Senior,
                Graduate
            }

            int studentID { get; set; }
            schoolYear year { get; set; }
            string firstName { get; set; }
            string lastName { get; set; }
            course[] enrollment { get; set; }

            student(int studentID, string firstName, string lastName, schoolYear year, course[] enrollment)
            {
                this.studentID = studentID;
                this.firstName = firstName;
                this.lastName = lastName;
                this.year = year;
                this.enrollment = enrollment;

                Program.studentList.Add(this);
            }

            public static student lookup(int id)
            {
                return (studentList.Find(x => x.studentID == id));
            }

        }

        public class course
        {

            int courseID { get; set; }
            string courseNum { get; set; }
            string title { get; set; }
            int creditHours { get; set; }
            student[] enrollment { get; set; }
            string description { get; set; }


            course( int courseid, string courseNum, string title, int creditHours, student[] enrollment, string description)
            {
                this.courseID = courseid;
                this.courseNum = courseNum;
                this.title = title;
                this.creditHours = creditHours;
                this.description = description;
                this.enrollment = enrollment;

                Program.courseList.Add(this);
            }

            public static course lookup(int courseID)
            {
                return (courseList.Find(x => x.courseID == courseID));
            }

        }

        public class registration
        {
            public enum semester
            {
                Fall,
                Spring,
                Winter,
                Summer
            }

            student student { get; set; }
            course course { get; set; }
            int regID { get; set; }
            semester semesterID { get; set; }
            int year { get; set; }


            registration(student student, course course, int regID, semester semester, int year)
            {
                this.student = student;
                this.course = course;
                this.regID = regID;
                this.semesterID = semester;
                this.year = year;

                Program.registrationList.Add(this);

            }

            public static List<registration> lookup(student studentLU)
            {
                return (registrationList.FindAll(x => x.student == studentLU));
            }

            public static List<registration> lookup(course courseLU)
            {
                return (registrationList.FindAll(x => x.course == courseLU));
            }

        }

        public static string optionsL1()
        {
            Console.WriteLine("Options:");
            Console.WriteLine("    Import:  import");
            Console.WriteLine("    Export:  export");
            Console.WriteLine("    Display: display");
            Console.WriteLine("    Add:     add");
            Console.WriteLine("    Remove:  remove");

            string response = Console.ReadLine();
            return (response);
        }

        public static string importOptions()
        {
            Console.WriteLine("What would you like to import?");
            Console.WriteLine("    Students:      students");
            Console.WriteLine("    Courses:       courses");
            Console.WriteLine("    Registrations: registrations");

            string response = Console.ReadLine();
            return (response);
        }


    }








}
