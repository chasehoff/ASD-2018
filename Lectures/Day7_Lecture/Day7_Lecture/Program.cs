using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_Lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            Practice myPractice = new Practice();
        }
    }
    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string School { get; set; }
        public Student()
        {
            Console.WriteLine("Student created!");
        }
        public override string ToString()
        {
            return $"{Name}\t {School}";
        }
    }
    class Practice
    {
        private List<Student> _students;
        public Practice()
        {
            _students = new List<Student>();

            for (int i = 0; i < 10; i++)
            {
                Student student = new Student();
                student.Name = "Student" + i;
                student.School = "Full Sail University";
                _students.Add(student);
            }
        }
        public void DisplayStudents()
        {
            _students.ForEach(Console.WriteLine);
        }
    }
}
