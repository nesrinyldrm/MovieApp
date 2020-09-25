using Microsoft.AspNetCore.Mvc;
namespace CoreMvc.Controllers
{
    public class MovieController:Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Create()
        {
            return View();
        }
        
        public IActionResult Details()
        {
            // TODO: Your code here
            return View();
        }

        public IActionResult List()
        {
            // TODO: Your code here
            return View();
        }
        
        
        
    }
}