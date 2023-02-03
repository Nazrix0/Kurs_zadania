using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentsAppMVC.Data;
using StudentsAppMVC.Models;

namespace StudentsAppMVC.Controllers
{
    public class StudentController : Controller
    {

        private MvcStudentsContext _dbContext;
        public StudentController(MvcStudentsContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: StudentController
        public ActionResult Index()
        {

            return View(_dbContext.Students);
        }

        // GET: StudentController/Details/5
        public ActionResult Details(int id)
        {
            var specificStudent = _dbContext.Students.FirstOrDefault(x => x.StudentId == id);
            _dbContext.SaveChanges();
            return View(specificStudent);
        }

        // GET: StudentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(StudentModel studentModel)
        {
            _dbContext.Students.Add(studentModel);
            _dbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        // GET: StudentController/Edit/5
        public ActionResult Edit(int id)
        {
            var student_edit = _dbContext.Students.FirstOrDefault(x => x.StudentId == id);
            return View(student_edit);
        }

        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        //IFormCollection
        public ActionResult Edit(int id, StudentModel collection)
        {
            var stunetd_edito = _dbContext.Students.FirstOrDefault(x => x.StudentId == id);
            collection.StudentId = id;
            collection.IsActive = stunetd_edito.IsActive;
            _dbContext.Remove(stunetd_edito);
            _dbContext.Students.Add(collection);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: StudentController/Delete/5
        public ActionResult Delete(int id)
        {
            var studentToBeDeleted = _dbContext.Students.FirstOrDefault(x => x.StudentId == id);
            return View(studentToBeDeleted);
        }

        // POST: StudentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            var studentToBeDeleted = _dbContext.Students.FirstOrDefault(x => x.StudentId == id);
            _dbContext.Remove(studentToBeDeleted);
            _dbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public ActionResult ChangeActiveStatus(int id)
        {
            var specificStudent = _dbContext.Students.FirstOrDefault(x => x.StudentId == id);
            specificStudent.IsActive = !specificStudent.IsActive;
            _dbContext.SaveChanges();
            return RedirectToAction("Details", "Student", new { id = specificStudent.StudentId });
        }
    }
}
