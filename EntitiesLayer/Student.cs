﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EntitiesLayer
{
   public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Subject> Subjects { get; set; }
    }
}
