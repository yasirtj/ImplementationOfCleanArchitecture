using EntitiesLayer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplicationLayer.Students.Queries
{
    public interface IGetAllStudents
    {
        IEnumerable<StudentModel> GetAll();
    }
    public class GetAllStudents : IGetAllStudents
    {
        private readonly IStudentRepository _studentRepository;
        public GetAllStudents(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public IEnumerable<StudentModel> GetAll()
        {
            var Model = _studentRepository.GetAll()
                .Select(i => new StudentModel { FirstName = i.FirstName, LastName = i.LastName })
                .ToList();
            return Model;
        }

    }
}
