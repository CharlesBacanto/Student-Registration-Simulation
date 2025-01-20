using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace studentRegistrationSimulation
{
    public static class UserPrompt
    {
        public static int studentCount()
        {
            int studentNum;

            Console.Write("Student Count: ");
            studentNum = Convert.ToInt32(Console.ReadLine());

            return studentNum;
        }

        public static string studentfirstName()
        {
            string studentfirstName;

            Console.Write("First Name: ");
            studentfirstName = Convert.ToString(Console.ReadLine());

            return studentfirstName;
        }

        public static string studentlastName()
        {
            string studentlastName;

            Console.Write("Last Name: ");
            studentlastName = Convert.ToString(Console.ReadLine());

            return studentlastName;
        }

        public static int studentyear()
        {
            int studentyear;

            Console.Write("Year: ");
            studentyear = Convert.ToInt32(Console.ReadLine());

            return studentyear;
        }

        public static string course()
        {
            string studentcourse;

            Console.Write("Course: ");
            studentcourse = Convert.ToString(Console.ReadLine());

            return studentcourse;
        }

        public static string studentsection()
        {
            string studentsection;

            Console.Write("Section: ");
            studentsection = Convert.ToString(Console.ReadLine());

            return studentsection;
        }
    }
}
