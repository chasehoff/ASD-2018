using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaseHoffman_CEO2
{
    class Course
    {
        public string courseTitle { get; set; }
        public Teacher yourTeacher { get; set; }
        public Student[] courseStudents { get; set; }
        public Course(string title, Teacher currentTeacher, Student[] students)
        {
            courseTitle = title;
            yourTeacher = currentTeacher;
            courseStudents = students;
        }
        public void AddStudent(int grade )
        {

        }
    }
}
