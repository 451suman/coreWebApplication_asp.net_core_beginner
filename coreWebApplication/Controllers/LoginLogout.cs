using Microsoft.AspNetCore.Mvc;

namespace coreWebApplication.Controllers
{
    public class LoginLogout : Controller
    {
        public IActionResult Login()
        {
            HttpContext.Session.SetString("Username", "suman");
            return RedirectToAction("loginSuccess");
        }
        public IActionResult loginSuccess()
        {
            ViewBag.Uname= HttpContext.Session.GetString("Username");
            return View();
        }
        public IActionResult Logouta()
        {
            try
            {
                if (HttpContext.Session.GetString("Username") != null)
                {
                    HttpContext.Session.Remove("Username");
                }
               // return View();
               return RedirectToAction("Privacy", "Home");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return RedirectToAction("Error"); // Handle the exception, e.g., redirect to an error page
            }
        }

    }
}
