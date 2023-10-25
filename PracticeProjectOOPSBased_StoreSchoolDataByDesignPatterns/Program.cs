using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProjectOOPSBased_StoreSchoolDataByDesignPatterns
{
    internal class Program
    {

        static void DisplayStudentsInClass(List<Student> students, string className)
        {
            Console.WriteLine($"Students in {className}:");
            foreach (var student in students)
            {
                if (student.ClassandSection == className)
                {
                    Console.WriteLine($"- {student.Name}");
                }
            }
        }

        static void DisplaySubjectsTaughtByTeacher(List<Subject> subjects, string teacherName)
        {
            Console.WriteLine($"{teacherName} teaches the following subjects:");
            foreach (var subject in subjects)
            {
                if (subject.Teacher == teacherName)
                {
                    Console.WriteLine($"- {subject.Name} ({subject.SubjectCode})");
                }
            }
        }
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("kishore", "class1"));
            students.Add(new Student("Chris", "class2"));
            students.Add(new Student("cersie", "class1"));
            students.Add(new Student("Lanni ", "class2"));


            List<Teacher> teachers = new List<Teacher>();
            teachers.Add(new Teacher("Kishan", "class1"));
            teachers.Add(new Teacher("Noolan", "class2"));

            List<Subject> subjects = new List<Subject>();
            subjects.Add(new Subject("Java", "Jv101", "Kishan"));
            subjects.Add(new Subject("C#", "C66", "Noolan"));



            Console.WriteLine("Which class students do you want to Display--- eiether *class1* or *class2*");
            string x = Console.ReadLine();
            DisplayStudentsInClass(students, x );


            Console.WriteLine("Which teacher subject do you want to Display--- eiether *Kishan* or *Noolan*");
            string y = Console.ReadLine();
            DisplaySubjectsTaughtByTeacher(subjects,y);


            Console.WriteLine("Press any key to exit >>>>>>>>>>>>>>>>>>>>>>>.");

            Console.Read();

        }

    }
}
