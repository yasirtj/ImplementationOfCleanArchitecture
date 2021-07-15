using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationLayer.Students;
using ApplicationLayer.Students.Commands;
using ApplicationLayer.Students.Queries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UILayer.ViewModels;

namespace UILayer.Controllers
{

    public class StudentController : Controller
    {
        private readonly ICreateStudent _createStudent;
        private readonly IEditStudent _editStudent;
        private readonly IDeleteStudent _deleteStudent;
        private readonly IGetAllStudents _getAllStudents;
        private readonly IGetStudentById _getStudentById;

        public StudentController(ICreateStudent createStudent, IEditStudent editStudent, IDeleteStudent deleteStudent, IGetAllStudents getAllStudents, IGetStudentById getStudentById)
        {
            _createStudent = createStudent;
            _editStudent = editStudent;
            _deleteStudent = deleteStudent;
            _getAllStudents = getAllStudents;
            _getStudentById = getStudentById;
        }
        // GET: Student
        public ActionResult Index()
        {
            var Vm = _getAllStudents.GetAll()
                .Select(i => new StudentViewModel { FirstName = i.FirstName, LastName = i.LastName })
                .ToList();


            return View(Vm);
        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(StudentViewModel studentModel)
        {
            if (ModelState.IsValid)
            {
                _createStudent.create(new StudentModel
                {

                    FirstName = studentModel.FirstName,
                    LastName = studentModel.LastName,
                    // Subjects = studentModel.Subjects

                });


                return View(studentModel);

            }


            //try
            //{ 
            //    StudentViewModel studentViewModel = new StudentViewModel();
            //    studentViewModel.FirstName = studentModel.FirstName;
            //    studentViewModel.LastName = studentModel.LastName;
            //    //studentViewModel.Subjects = studentModel.Subjects;

            //    // TODO: Add insert logic here

            //    //var convertedModel = ConvertToViewModel(studentModel);
            //    _createStudent.create(studentViewModel);
            //    return RedirectToAction(nameof(Index));
            //}
            //catch
            //{
            //    return View(studentViewModel);
            //}
            return RedirectToAction("Index");

        }

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Student/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Student/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        public StudentModel ConvertToModel(StudentViewModel studentViewModel)
        {
            var model = new StudentModel();

            model.FirstName = studentViewModel.FirstName;
            model.LastName = studentViewModel.LastName;
            // model.Subjects = studentViewModel.Subjects;

            return model;
        }
        public StudentViewModel ConvertToViewModel(StudentModel studentModel)
        {

            StudentViewModel model = new StudentViewModel();


            model.FirstName = studentModel.FirstName;
            model.LastName = studentModel.LastName;
            //model.Subjects = studentModel.Subjects;

            return model;
        }
    }
}