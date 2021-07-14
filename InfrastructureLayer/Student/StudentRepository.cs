using ApplicationLayer.Students;
using InfrastructureLayer.Context;
using InfrastructureLayer.GenericRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfrastructureLayer.Student
{
   public class StudentRepository :GenericRepository<EntitiesLayer.Student>, IStudentRepository
    {
        public StudentRepository(IStudentDbContext context) :base(context){ }
     
    }
}
