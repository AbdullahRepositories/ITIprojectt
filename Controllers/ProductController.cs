using ITIproject.Models;
using Microsoft.AspNetCore.Mvc;

namespace ITIproject.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            ProductSampleData products = new ProductSampleData();
            List<Product> ProductList = products.GetAll();
            return View("ViewAllList",ProductList);
        }
        public IActionResult Details(int id)
        {
            ProductSampleData productsBL = new ProductSampleData();
            Product productModel= productsBL.GetById(id);
            return View("Details",productModel);    
        }
    }
}
