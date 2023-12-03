using ITIproject.Models;
using Microsoft.AspNetCore.Mvc;

namespace ITIproject.Controllers
{
    public class StudentController : Controller
    {
        ITIEntities _context=new ITIEntities(); 
        //public StudentController(ITIEntities context)
        //{
        //    _context = context;
        //}

        public IActionResult Index()
        {
            List<string> branches=new List<string>();
            branches.Add("sana");
            branches.Add("hajah");
            branches.Add("hodidah");
            ViewData["branches"] = branches;
            branches.Add("Ebb");
            ViewBag.Branches = branches;
            ViewData["Message"] = "How are you";
            
            Student? student = _context.Student.FirstOrDefault();
            return View("details",student);
        }
    }
}
