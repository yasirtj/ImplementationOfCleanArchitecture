using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationLayer.Subjects.Commands
{
    public interface IEditSubject
    {
        void edit(int entityToUpdateId, SubjectModel subjectModel);
    }

    public class EditSubject : IEditSubject
    {
        private readonly ISubjectRepository _subjectRepository;

        public EditSubject(ISubjectRepository subjectRepository)
        {
            _subjectRepository = subjectRepository;
        }

        public void edit(int entityToUpdateId, SubjectModel subjectModel)
        {
            string result = "";
            if (entityToUpdateId == null || entityToUpdateId == 0)
            {
                result = "NotFound";
            }
            else
            {
                var entityToModel = Convert(subjectModel);
                _subjectRepository.Update(entityToUpdateId, entityToModel);
                _subjectRepository.Save();
            }
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
