using ITIproject.Models;
using Microsoft.AspNetCore.Mvc;

namespace ITIproject.Controllers
{
    public class DeptController : Controller
    {
        ITIEntities context = new ITIEntities();
        public IActionResult Index()
        {
            
            List<Department> deptsModel=context.Department.ToList();
            return View("index",deptsModel);
        }

        public IActionResult GetStudents()
        {
List<Student> studentsModel=context.Student.ToList();
            return View();
        }
    }
}
