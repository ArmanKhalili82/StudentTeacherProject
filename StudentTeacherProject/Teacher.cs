﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTeacherProject
{
    public class Teacher: Person
    {
        public string Course { get; set; }

        public override void ShowName(string name)
        {
            base.ShowName(name);
        }
    }
}