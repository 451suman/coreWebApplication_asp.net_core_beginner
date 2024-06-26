using coreWebApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace coreWebApplication.Controllers
{
    public class CustomerController : Controller
    {
        public static List<Customer> customers = new List<Customer>
        {
            new Customer() { Id = 1, Name = "John Doe", Address = "asdasdasdasd" },
            new Customer (){ Id = 2, Name = "John Smith", Address = "asdkahsdnlk" }
        };
        public IActionResult Index()
        {
            ViewBag.message = "Customer Management System";
            ViewBag.CustomerCount = customers.Count;
            ViewBag.CustomerList = customers;
            return View();
        }
        public IActionResult Details()
        {
            ViewData["message"] = "Customer Management System";
            ViewData["CustomerCount"] = customers.Count;
            ViewData ["CustomerList"] = customers;
            return View();
        }

        public IActionResult tempdatademo()
        {
            TempData["message"] = "Customer Management System";
            TempData["CustomerCount"] = customers.Count;
            TempData["CustomerList"] = customers;
            return View();
        }
        public IActionResult method2()
        {
            if (TempData["message"] == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                TempData["msg"] = TempData["message"].ToString();
                return View();
            }
        }
    }
}
