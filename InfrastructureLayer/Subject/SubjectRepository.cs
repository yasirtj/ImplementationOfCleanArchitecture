using ApplicationLayer.Subjects;
using InfrastructureLayer.Context;
using InfrastructureLayer.GenericRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfrastructureLayer.Subject
{
   public class SubjectRepository:GenericRepository<EntitiesLayer.Subject> , ISubjectRepository
    {
        public SubjectRepository(IStudentDbContext context) : base(context) { }
       
    }
}
