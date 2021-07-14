using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationLayer.Subjects.Commands
{
    public interface IDeleteSubject
    {
        void delete(SubjectModel subjectModel);
    }
    class DeleteSubject : IDeleteSubject
    {
        private readonly ISubjectRepository _subjectRepository;
        public DeleteSubject(ISubjectRepository subjectRepository)
        {
            _subjectRepository = subjectRepository;
        }

        public void delete(SubjectModel subjectModel)
        {
            var entityToModel = Convert(subjectModel);
            _subjectRepository.Delete(subjectModel.Id);
            _subjectRepository.Save();
        }
        public EntitiesLayer.Subject Convert(SubjectModel subjectModel)
        {
            var subject = new EntitiesLayer.Subject();
            subject.Id = subjectModel.Id;
            subject.Student = subjectModel.Student;
            subject.StudentId = subjectModel.StudentId;
            //subject.Grade = subjectModel.Grade;

            return subject;
        }
    }
}
