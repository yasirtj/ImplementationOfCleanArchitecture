using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationLayer.Students.Commands
{
    public interface ICreateStudent
    {
        void create(StudentModel studentModel);
    }

    public class CreateStudent : ICreateStudent
    {
        private readonly IStudentRepository _studentRepository;

        public CreateStudent(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public void create(StudentModel studentModel)
        {
            var entityToModel = Convert(studentModel);
            _studentRepository.Insert(entityToModel);
            _studentRepository.Save();
        }

      public EntitiesLayer.Student Convert(StudentModel studentModel)
        {
            var student = new EntitiesLayer.Student();
            student.Id = studentModel.Id;
            student.FirstName = studentModel.FirstName;
            student.LastName = studentModel.LastName;
            //student.Subjects = studentModel.Subjects;

            return student;
        }
    }
}
