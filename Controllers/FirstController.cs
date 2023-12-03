using Microsoft.AspNetCore.Mvc;

namespace ITIproject.Controllers
{
    public class FirstController : Controller
    {
        public IActionResult Index()
        {
            return View();
        } 
        public ViewResult GetView()
        {
           
            ViewResult result = new ViewResult();
            result.ViewName = "MyView";
            return result;
        }
    }
}
