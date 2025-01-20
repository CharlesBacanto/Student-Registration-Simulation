using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace studentRegistrationSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Student[] students = new Student[UserPrompt.studentCount()];

            for(int i = 0; i < students.Length; i++)
            {
                int studentNumber = i + 1;
                Console.WriteLine();
                Console.WriteLine("Student #" + studentNumber);
                students[i] = new Student(UserPrompt.studentfirstName(), UserPrompt.studentlastName(), UserPrompt.studentyear(), UserPrompt.course(), UserPrompt.studentsection());
            }

            Console.WriteLine();
            Console.WriteLine("Introduce");
            foreach(Student student in students)
            {
                student.introduce();
                Console.WriteLine();
            }
        }
    }
}