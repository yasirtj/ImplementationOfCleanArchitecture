using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationLayer.Students.Commands
{
    public interface IEditStudent
    {
        void edit(int entityToUpdateId , StudentModel studentModel);
    }
    public class EditStudent : IEditStudent
    {
        private readonly IStudentRepository _studentRepository;
        public EditStudent(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public void edit(int entityToUpdateId, StudentModel studentModel)
        {
            string result = "";
            if (entityToUpdateId == null || entityToUpdateId == 0)
            {
                result = "NotFound";
            }
            else
            {
                var entityToModel = Convert(studentModel);
                _studentRepository.Update(entityToUpdateId, entityToModel);
                _studentRepository.Save();
            }
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
