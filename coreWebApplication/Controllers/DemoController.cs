using Microsoft.AspNetCore.Mvc;

namespace coreWebApplication.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
    }
}
