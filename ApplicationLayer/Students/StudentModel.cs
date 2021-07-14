using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationLayer.Students
{
   public class StudentModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Subject> Subjects { get; set; }
    }
}
