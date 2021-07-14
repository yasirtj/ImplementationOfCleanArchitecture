using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationLayer.Subjects.Queries
{
    public interface IGetSubjectById
    {
        SubjectModel GetById(int Id);
    }
    public class GetSubjectById : IGetSubjectById
    {
        private readonly ISubjectRepository _subjectRepository;
        public GetSubjectById(ISubjectRepository subjectRepository)
        {
            _subjectRepository = subjectRepository;    
        }
        
        public SubjectModel GetById(int Id)
        {
            var entity = _subjectRepository.GetById(Id);
            var model = Convert(entity);
            return model;
        }
        public SubjectModel Convert(EntitiesLayer.Subject subject)
        {
            var entity = new SubjectModel();
            entity.Id = subject.Id;
            entity.StudentId = subject.StudentId;
            entity.Student = subject.Student;
          //  entity.Grade = subject.Grade;

            return entity;

        }
    }
}
