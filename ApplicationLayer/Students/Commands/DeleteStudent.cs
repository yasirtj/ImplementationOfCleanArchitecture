using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationLayer.Students.Commands
{
    public interface IDeleteStudent
    {
        void delete(StudentModel studentModel);
    }
    public class DeleteStudent : IDeleteStudent
    {
        private readonly IStudentRepository _studentRepository;
        public DeleteStudent(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public void delete(StudentModel studentModel)
        {
            var entityToModel = Convert(studentModel);
            _studentRepository.Delete(studentModel.Id);
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
