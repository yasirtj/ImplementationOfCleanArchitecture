using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationLayer.Subjects.Queries
{
    public interface IGetAllSubjects
    {
        IEnumerable<EntitiesLayer.Subject> GetAll();
    }
    public class GetAllSubjects : IGetAllSubjects
    {
        private readonly ISubjectRepository _subjectRepository;
        public GetAllSubjects(ISubjectRepository subjectRepository)
        {
            _subjectRepository = subjectRepository;
        }
        public IEnumerable<Subject> GetAll()
        {
            return _subjectRepository.GetAll();
        }
    }
}
