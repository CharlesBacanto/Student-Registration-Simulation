using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentRegistrationSimulation
{
    //Class for Encapsulation, Getters, Setters and Constructor
    internal class Student
    {   
        //Private variable declaration to protect the values
        private string firstName;
        private string lastName;
        private int year;
        private string course;
        private string section;


        //Getters and Setters
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public int Year
        {
            get { return year; }
            set { if (value > 0 && value <= 5) year = value; // Setting the limit of Year Level up to 5 years
                else Console.WriteLine("Year Level Input is invalid");
            }
        }

        public string Course
        {
            get { return course; }
            set { course = value; }
        }

        public string Section
        {
            get { return section; }
            set { section = value; }
        }


        //Constructor for Student
        public Student(string firstname, string lastname, int year, string course, string section)
        {
            FirstName = firstname;
            LastName = lastname;
            Year = year;
            Course = course;
            Section = section;
        }


        //Method for printing out Student's Introduction
        public void introduce()
        {
            Console.WriteLine("I'am " + FirstName + " " + LastName);
            Console.WriteLine(Year + "th Year a " + Course + " student from class " + Section);
        }
    }
}
