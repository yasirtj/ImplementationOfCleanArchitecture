using System;
using System.Collections.Generic;
using System.Text;

namespace EntitiesLayer
{
    public enum Grade
    {
        A, B, C, D, F
    }
    public class Subject
    {  
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Grade? Grade { get; set; }
        public Student Student { get; set; }
    }
}
