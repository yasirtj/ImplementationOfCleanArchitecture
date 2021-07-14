using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationLayer.Students.Queries
{
    public interface IGetAllStudents
    {
        IEnumerable<EntitiesLayer.Student> GetAll();
    }
    public class GetAllStudents : IGetAllStudents
    {
        private readonly IStudentRepository _studentRepository;
        public GetAllStudents(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public IEnumerable<Student> GetAll()
        {
            return _studentRepository.GetAll();
        }
    }
}
