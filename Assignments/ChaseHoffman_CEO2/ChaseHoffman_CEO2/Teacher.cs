﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaseHoffman_CEO2
{
    class Teacher:Person
    {
        string[] EdBackground { get; set; }
        public Teacher(string[] edb, string name, int age) : base(name, age)
        {

        }
    }
}
