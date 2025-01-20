using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace studentRegistrationSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array of Students
            Student[] students = new Student[UserPrompt.studentCount()]; // The UserPrompt.studentCount() is a method for getting the student count UserInput


            //For Loop of Student Registration
            for(int i = 0; i < students.Length; i++)
            {
                int studentNumber = i + 1; //Student count since array index starts with 0 we need to add 1 to begin with student count number 1
                Console.WriteLine(); //Space
                Console.WriteLine("Student #" + studentNumber); // Print Student Count

                // Constructor of Students with corresponding methods for getting the student credentials
                students[i] = new Student(UserPrompt.studentfirstName(), UserPrompt.studentlastName(), UserPrompt.studentyear(), UserPrompt.course(), UserPrompt.studentsection()); 
                
            }

            Console.WriteLine();//Space
            Console.WriteLine("Introduce");//Print Introduce

            // For Each loop to introduce each students
            foreach(Student student in students)
            {
                student.introduce();// Introduce Method
                Console.WriteLine();// Space
            }
        }
    }
}