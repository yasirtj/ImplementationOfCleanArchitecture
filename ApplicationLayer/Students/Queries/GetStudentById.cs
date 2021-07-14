using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationLayer.Students.Queries
{
    public interface IGetStudentById
    {
        StudentModel GetById(int Id);
    }
    public class GetStudentById : IGetStudentById
    {
        private readonly IStudentRepository _studentRepository;
        public GetStudentById(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public StudentModel GetById(int Id)
        {
            var entity = _studentRepository.GetById(Id);
            var model = Convert(entity);
            return model;

        }
        public StudentModel Convert(EntitiesLayer.Student student)
        {
            var entity = new StudentModel();
            entity.Id = student.Id;
            entity.FirstName = student.FirstName;
            //entity.Subjects = student.Subjects;

            return entity;

        }
    }
}
