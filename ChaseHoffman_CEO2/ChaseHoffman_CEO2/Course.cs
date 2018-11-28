using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaseHoffman_CEO2
{
    class Course
    {
        string courseTitle;
        Teacher yourTeacher;
        Student[] courseStudents;
        public Course(string title, Teacher currentTeacher, Student[] students)
        {
            courseTitle = title;
            yourTeacher = currentTeacher;
            courseStudents = students;
        }
    }
}
