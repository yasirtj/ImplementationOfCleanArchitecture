using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UILayer.ViewModels
{
    public enum Grade
    {
        A, B, C, D, F
    }
    public class SubjectViewModel
    {
        
        public int StudentId { get; set; }
        public Grade? Grade { get; set; }
        public StudentViewModel Student { get; set; }
    }
}
