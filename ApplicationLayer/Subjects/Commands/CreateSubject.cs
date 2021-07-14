using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationLayer.Subjects.Commands
{
    public interface ICreateSubject
    {
        void create(SubjectModel subjectModel);
    }

    public class CreateSubject : ICreateSubject
    {
        private readonly ISubjectRepository _subjectRepository;

        public CreateSubject(ISubjectRepository subjectRepository)
        {
            _subjectRepository = subjectRepository;
        }

        public void create(SubjectModel subjectModel)
        {
            var entityToModel = Convert(subjectModel);
            _subjectRepository.Insert(entityToModel);
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
