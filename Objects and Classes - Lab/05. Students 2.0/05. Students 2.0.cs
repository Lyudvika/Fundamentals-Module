using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<StudentsInfo> students = new List<StudentsInfo>();
            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] token = command.Split();
                string firstName = token[0];
                string lastName = token[1];
                int age = int.Parse(token[2]);
                string homeTown = token[3];

                if (IsStudentExisting(students, firstName, lastName))
                {
                    StudentsInfo student = GetStudent(students, firstName, lastName);

                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.HomeTown = homeTown;
                }
                else
                {
                    StudentsInfo student = new StudentsInfo()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        HomeTown = homeTown
                    };
                    students.Add(student);
                }
            }

            string filterCity = Console.ReadLine();

            foreach (StudentsInfo student in students)
            {
                if (student.HomeTown == filterCity)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }

        static bool IsStudentExisting(List<StudentsInfo> students, string firstName, string lastName)
        {
            foreach (StudentsInfo student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }
            return false;
        }

        static StudentsInfo GetStudent(List<StudentsInfo> students, string firstName, string lastName)
        {
            StudentsInfo existingStudent = null;

            foreach (StudentsInfo student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    existingStudent = student;
                }
            }

            return existingStudent;
        }
    }

    public class StudentsInfo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
}