﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTeacherProject
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }

        public virtual void ShowName()
        {
            Console.WriteLine();
        }
    }
}
