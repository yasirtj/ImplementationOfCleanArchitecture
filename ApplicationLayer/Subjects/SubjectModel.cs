using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationLayer.Subjects
{
    public enum Grade
    {
        A, B, C, D, F
    }
    public class SubjectModel
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Grade? Grade { get; set; }
        public Student Student { get; set; }
    }
}
