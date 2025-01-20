using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace studentRegistrationSimulation
{   
    //UserPrompt Class is used for getting UserInputs
    public static class UserPrompt
    {   
        //Method for getting the population of the Student to be registered
        public static int studentCount()
        {
            int studentNum;

            Console.Write("Student Count: ");
            studentNum = Convert.ToInt32(Console.ReadLine());

            return studentNum;
        }

        //Method for getting the First Name
        public static string studentfirstName()
        {
            string studentfirstName;

            Console.Write("First Name: ");
            studentfirstName = Convert.ToString(Console.ReadLine());

            return studentfirstName;
        }

        //Method for getting the Last Name
        public static string studentlastName()
        {
            string studentlastName;

            Console.Write("Last Name: ");
            studentlastName = Convert.ToString(Console.ReadLine());

            return studentlastName;
        }

        //Method for getting the Year
        public static int studentyear()
        {
            int studentyear;

            Console.Write("Year: ");
            studentyear = Convert.ToInt32(Console.ReadLine());

            return studentyear;
        }


        //Method for getting the Course
        public static string course()
        {
            string studentcourse;

            Console.Write("Course: ");
            studentcourse = Convert.ToString(Console.ReadLine());

            return studentcourse;
        }

        //Method for getting the Section
        public static string studentsection()
        {
            string studentsection;

            Console.Write("Section: ");
            studentsection = Convert.ToString(Console.ReadLine());

            return studentsection;
        }
    }
}
