using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaseHoffman_CEO2
{
    class Student:Person
    {
        public int Grade { get; set; }
        public string Name { get; set; }
        public Student(int grade, string name, int age) : base(name,age)
        {
            Grade = grade;
            Name = name;
        }
    }
}
